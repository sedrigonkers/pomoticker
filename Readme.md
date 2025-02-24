# PomoTicker

**Project for** “Component Software Development - INFO3 - ZS 24/25”  
**Author:** Serhii Tsurkan

## Name:
PomoTicker

## Description:
This program is a simple Pomodoro timer that helps users manage work and break intervals.

### What is the Pomodoro method?
Pomodoro is a popular time management technique developed by Francesco Cirillo. The principle involves breaking work into shorter segments, typically 25 minutes, followed by a short break (5 minutes). This method increases productivity by reducing mental fatigue and improving focus.

## Program Features:
- **Start/Stop Timer:** Allows users to start or stop the timer for work or break sessions.
- **Reset Timer:** Resets the timer to its initial value.
- **Skip Phase:** Skips the current phase (work/break) and switches to the next.
- **Adjust Settings:** Users can set the duration of work and break intervals.
- **Phase Switch Notification:** Displays a message informing the user to start working or take a break.

## Design of Main Variables and Data Structures:
- **PomodoroTimer (timer):** A class that implements the logic of the timer, including work and break phases. It includes attributes such as work and break interval lengths, the remaining time, and the phase flag (work/break).
- **Events:** The PomodoroTimer class uses events to notify changes such as timer ticks, phase switches, or timer stops.
- **TimerForm (form):** The main user interface of the application, which shows the current state of the timer and allows interaction through buttons.

## Conceptual Program Description:
1. **Start Timer:** The timer starts counting down from the preset value (typically 25 minutes for work and 5 minutes for break).
2. **Phase Switch:** Once the time elapses, the phase (work/break) switches, and the user is notified of the change.
3. **User Interaction:** Using the buttons, the user can start/stop the timer, reset it, or adjust settings.
4. **Settings:** Users can customize the duration of work and break intervals.

## Input Limitations and Potential Issues:
- The duration of both work and break intervals must be entered in minutes, with a maximum of 90.
- The user must correctly interact with the buttons to avoid unexpected behavior of the timer.
- The program interface is only available in English.

## Technical Notes:
- The program is written in C# using the Windows Forms library.
- It uses the Timer class for countdown and events to notify changes.
- The interface is simple and intuitive, designed to meet the basic requirements of the Pomodoro technique.
