import asyncio
import keyboard

def feldolgoz(lista):
    my_keys=""
    for i in range(1,len(lista)-1):
        if lista[i].event_type=="down":
            my_keys+=lista[i].name
    return my_keys

def olvas():
    while True:
        keyboard.wait("f6")
        recorded=keyboard.record(until="f7")
        return feldolgoz(recorded)

tmp=olvas()

print()
print("---------")
print(tmp)
print("---------")