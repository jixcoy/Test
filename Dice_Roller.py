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

while True:
    start = input("Type \"Roll\" to roll or \"Quit\" to stop playing.\n")
    if start.lower() == "quit":
        break

    roll = random.randint(1, 9)

    print(f"\nRoll Result: {roll}")
    print("\n===========================\n")

print(f"\nThanks for playing Dice Roll {user_name}")