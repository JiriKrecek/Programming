import imp
from operator import irshift, is_, truediv


players = 937
rounds = 0
games = 0

is_odd = False

while players > 1:
    if players%2 == 1:
        is_odd = True
        players -= 1
    players /= 2
    games += players
    rounds += 1
    if is_odd:
        players += 1
        is_odd = False

print(players)
print(rounds)
print(games)
