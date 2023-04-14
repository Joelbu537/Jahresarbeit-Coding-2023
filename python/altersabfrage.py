from datetime import datetime
from time import sleep

name = input("Bitte gib hier deinen Namen ein: ")
year = int(input("Hallo " + name + ", bitte gib dein Geburtsjahr ein (YYYY): "))

month = 0
while ( month < 1 or month > 12):
    month = int(input("Bitte gib deinen Geburtsmonat ein (MM): "))

currentMonth = int(datetime.now().strftime('%m'))
currentYear = int(datetime.now().strftime('%Y'))

trueYear = currentYear - year
trueMonth = currentMonth - month
if trueMonth < 0:
    trueYear = trueYear - 1

print("Du bist " + str(trueYear) + " Jahre alt, " + name + ".")
sleep(30)
