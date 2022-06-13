"""
Programmers: John Ixcoy     Date: 6/13/2022
Project Name: Dice Roller    Language: Python

Description: 
Basic dice roller game using Python. 

Libraries: random
"""
import random


print("Welcome to Dice Roller\n\n")

user_name = input("Enter your name: ")
running = True

while running:
    start = input("Type \"Enter\" to roll or \"Quit\" to stop playing.\n")
    if start.lower() == "quit":
        running = False

    roll = random.randint(1, 9)
    print(f"Roll Result: {roll}")
    print("\n===========================\n")
