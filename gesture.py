# gesture control python program for controlling certain functions in windows pc
# Code by BalaAppu
# Website: www.electronicshub.org

import serial                                      # add Serial library for serial communication
import pyautogui                                   # add pyautogui library for programmatically controlling the mouse and keyboard.

Arduino_Serial = serial.Serial('com3',9600)       # Initialize serial and Create Serial port object called Arduino_Serial
 
while 1:
    print("line received")
    incoming_data = str (Arduino_Serial.readline())
    print("line read")
    print(incoming_data)                            
     

    if 'next' in incoming_data:                    # if incoming data is 'next'
        pyautogui.hotkey('ctrl', 'pgdn')           # perform "ctrl+pgdn" operation which moves to the next tab
        print("h")
        
    if 'previous' in incoming_data:                # if incoming data is 'previous'
        pyautogui.hotkey('ctrl', 'pgup')           # perform "ctrl+pgup" operation which moves to the previous tab
        print("h")
    if 'down' in incoming_data:                    # if incoming data is 'down'
        #pyautogui.press('down')                   # performs "down arrow" operation which scrolls down the page
        pyautogui.press('r') 
        print("h") 
    if 'up' in incoming_data:                      # if incoming data is 'up'
        #pyautogui.press('up')
        # performs "up arrow" operation which scrolls up the page
        print("h")
        pyautogui.press('k')
        
    if 'change' in incoming_data:                  # if incoming data is 'change'
        pyautogui.keyDown('alt')                   # performs "alt+tab" operation which switches the tab
        pyautogui.press('tab')
        pyautogui.keyUp('alt')
        print("h")
    incoming_data = "";                            # clears the data
