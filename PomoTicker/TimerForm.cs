using System;
using System.Windows.Forms;

namespace PomoTicker
{
    // Main form for the Pomodoro timer application
    public partial class TimerForm : Form 
    {
        private readonly PomodoroTimer _pomodoroTimer; // Instance of PomodoroTimer logic

        // Constructor that initializes the form and Pomodoro timer 
        public TimerForm()
        {
            InitializeComponent();
            _pomodoroTimer = new PomodoroTimer();

            // Subscribe to Pomodoro timer events
            _pomodoroTimer.TimerTick += OnTimerTick;
            _pomodoroTimer.PhaseChanged += OnPhaseChanged; 
            _pomodoroTimer.TimerStarted += OnTimerStarted;
            _pomodoroTimer.TimerStopped += OnTimerStopped;

            // Initialize the UI with default data
            InitializeUI();
        }

        /// <summary>
        /// Initializes the UI elements with the default data.
        /// Updates timer and phase labels. Updates start/pause button text.
        /// </summary>
        private void InitializeUI()
        {
            UpdateTimerLabel(_pomodoroTimer.TimeRemaining);
            UpdatePhaseLabel(_pomodoroTimer.IsWorkingPhase);
            UpdateStartPauseButton(_pomodoroTimer.IsRunning);
        }

        /// <summary>
        /// Event handler for the timer tick event. Updates the timer label.
        /// </summary>
        private void OnTimerTick(object sender, EventArgs e)
        {
            // Update the UI with the remaining time
            UpdateTimerLabel(_pomodoroTimer.TimeRemaining);
        }

        /// <summary>
        /// Event handler for phase change (work/break). Updates the phase label and displays a message.
        /// </summary>
        private void OnPhaseChanged(object sender, EventArgs e)
        {
            // Update phase label and show message when phase changes (Work/Break) 
            UpdatePhaseLabel(_pomodoroTimer.IsWorkingPhase); 
            ShowPhaseSwitchMessage(_pomodoroTimer.IsWorkingPhase);
        } 

        /// <summary>
        /// Event handler for when the timer starts. Updates the start/pause button text.
        /// </summary> 
        private void OnTimerStarted(object sender, EventArgs e)   
        {
            UpdateStartPauseButton(true); // Update button text to "STOP" 
        }

        /// <summary>
        /// Event handler for when the timer stops. Updates the start/pause button text.
        /// </summary>
        private void OnTimerStopped(object sender, EventArgs e)
        {
            UpdateStartPauseButton(false); // Update button text to "START"
        }

        /// <summary>
        /// Updates the timer label on the form with the current time remaining.
        /// </summary> 
        private void UpdateTimerLabel(TimeSpan timeRemaining)
        {
            // Format and display the time remaining in minutes:seconds format
            TimerLabel.Text = $"{(int)timeRemaining.TotalMinutes:D2}:{timeRemaining.Seconds:D2}";
        }

        /// <summary>
        /// Updates the phase label (Work/Break) on the form.
        /// </summary>  
        private void UpdatePhaseLabel(bool isWorkingPhase)  
        {
            // Display "Work!" if working phase, otherwise "Break"
            PhaseLabel.Text = isWorkingPhase ? "Work!" : "Break";
        }

        /// <summary>
        /// Updates the start/pause button text based on whether the timer is running. 
        /// </summary>
        private void UpdateStartPauseButton(bool isTimerRunning)
        {
            StartPauseButton.Text = isTimerRunning ? "STOP" : "START"; // If the timer is running sets button text to "STOP", does opposite if the timer is stopped
        }

        /// <summary>
        /// Displays a message about the phase switch (Work/Break).  
        /// </summary>
        private void ShowPhaseSwitchMessage(bool isWorkingPhase)
        {
            // Show a message box indicating whether the user should work or take a break 
            MessageBox.Show(
                isWorkingPhase ? "Break's over! Get back to work." : "Work done! Take a break.",
                "Time's up",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        /// <summary>
        /// Event handler for the start/pause button. Starts or stops the Pomodoro timer.
        /// </summary>
        private void StartPauseButton_Click(object sender, EventArgs e)
        {
            if (_pomodoroTimer.IsRunning)
            {
                _pomodoroTimer.Stop(); // Stop the timer
            }
            else
            {
                _pomodoroTimer.Start(); // Start the timer
            }
        }

        /// <summary>
        /// Event handler for the reset button. Resets the timer to the initial phase. 
        /// </summary>
        private void ResetButton_Click(object sender, EventArgs e)
        {
            // Stop the timer and reset the phase 
            _pomodoroTimer.Stop();
            _pomodoroTimer.Reset();
            InitializeUI(); // Reinitialize the UI 
        }
        
        /// <summary>
        /// Event handler for the skip phase button. Skips the current phase and switches to the next. 
        /// </summary>
        private void SkipPhaseButton_Click(object sender, EventArgs e)
        {
            // Stop the timer, switch phase, and reset
            _pomodoroTimer.Stop();
            _pomodoroTimer.SkipPhase();
            InitializeUI(); // Reinitialize the UI 
        }

        /// <summary> 
        /// Event handler for applying settings. Updates work/break durations and resets the timer.
        /// </summary> 
        private void ApplySettingsButton_Click(object sender, EventArgs e)
        {
            // Update the work and break durations based on user input  
            _pomodoroTimer.WorkDuration = TimeSpan.FromMinutes((int)WorkMinutesInput.Value);
            _pomodoroTimer.BreakDuration = TimeSpan.FromMinutes((int)BreakMinutesInput.Value); 
            _pomodoroTimer.Stop(); // Stop the timer 
            _pomodoroTimer.Reset(); // Reset the timer with new settings
            InitializeUI(); // Reinitialize the UI 

            // Show confirmation message
            MessageBox.Show("Settings updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TimerForm_Load(object sender, EventArgs e)
        {

        }
    }

    /// <summary>
    /// Logic class for the Pomodoro timer.
    /// This class handles the timer functionality, including work/break phases.
    /// </summary> 
    public class PomodoroTimer
    {
        private readonly Timer _timer; // Timer to track time in seconds
        private TimeSpan _timeRemaining; // Time remaining in the current phase

        public TimeSpan WorkDuration { get; set; } = TimeSpan.FromMinutes(25); // Default work duration
        public TimeSpan BreakDuration { get; set; } = TimeSpan.FromMinutes(5); // Default break duration  
        public bool IsWorkingPhase { get; private set; } = true; // Flag to track if it's the work phase
        public bool IsRunning { get; private set; } = false; // Flag to track if the timer is running 
        public TimeSpan TimeRemaining => _timeRemaining; // Property to get remaining time

        // Events to notify when the timer makes changes
        public event EventHandler TimerTick;
        public event EventHandler PhaseChanged;
        public event EventHandler TimerStopped;
        public event EventHandler TimerStarted;

        // Constructor that initializes the timer and sets default values
        public PomodoroTimer()
        {
            _timer = new Timer { Interval = 1000 }; // Timer interval set to 1 second 
            _timer.Tick += OnTimerTick; // Subscribe to the timer tick event 
            Reset(); // Initialize the timer with default values 
        }

        /// <summary>
        /// Starts the Pomodoro timer.
        /// </summary>  
        public void Start()
        {
            if (!IsRunning)
            {
                _timer.Start(); // Start the timer
                IsRunning = true; // Mark the timer as running
                TimerStarted?.Invoke(this, EventArgs.Empty); // Trigger TimerStarted event
            }
        }

        /// <summary>
        /// Stops the Pomodoro timer.
        /// </summary>
        public void Stop() 
        {
            if (IsRunning)
            {
                _timer.Stop(); // Stop the timer
                IsRunning = false; // Mark the timer as stopped
                TimerStopped?.Invoke(this, EventArgs.Empty); // Trigger TimerStopped event
            }
        }

        /// <summary>
        /// Resets the timer to the initial value based on the current phase (work/break).
        /// </summary> 
        public void Reset()
        {
            // Set the remaining time based on the current phase
            _timeRemaining = IsWorkingPhase ? WorkDuration : BreakDuration;
            TimerTick?.Invoke(this, EventArgs.Empty); // Trigger TimerTick event
        }

        /// <summary>
        /// Skips the current phase and switches to the next one.
        /// </summary>
        public void SkipPhase()
        {
            SwitchPhase(); // Switch phase  
            Reset(); // Reset the timer to the new phase
        }

        /// <summary>
        /// Handles the timer tick event. Decreases the time remaining each second. 
        /// </summary>
        private void OnTimerTick(object sender, EventArgs e)
        {
            _timeRemaining = _timeRemaining.Subtract(TimeSpan.FromSeconds(1)); // Decrease remaining time
            TimerTick?.Invoke(this, EventArgs.Empty); // Trigger TimerTick event

            // If time is up, stop the timer and switch phase
            if (_timeRemaining <= TimeSpan.Zero) 
            {
                Stop(); // Stop the timer
                SwitchPhase(); // Switch to the next phase (Work <-> Break)  
                Reset(); // Reset the timer for the new phase
            }
        }

        /// <summary>
        /// Switches the phase (from work to break or vice versa) and triggers the PhaseChanged event.
        /// </summary> 
        private void SwitchPhase()
        {
            IsWorkingPhase = !IsWorkingPhase; // Toggle between work and break phases 
            PhaseChanged?.Invoke(this, EventArgs.Empty); // Trigger PhaseChanged event
        }
    }
}
