from cmath import pi
import random

def monty(strategy):
    doors = ["a", "b", "c"]
    car = random.choice(doors)
    pick = random.choice(doors)

    open = random.choice([d for d in doors if d != car and d != pick])

    match strategy:
        case "switch":
            pick = random.choice([d for d in doors if d != open and d != pick])

    if  pick == car:
        return True
    else: 
        return False
    

def main():
    
    number_of_games = 50000000
    wins = 0

    for i in range(number_of_games):
        if monty("switch") == True:
            wins += 1

    print("Win rate is: ", wins*100/number_of_games, "%")
    print(monty("switch"))


if __name__ == "__main__":
    main()
