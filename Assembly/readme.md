# Assembly

<!-- Készült: Keresztes Péter (EKE) által oktatott anyagból -->

## Környezet beállítások

1. Program:
  - [DOSBox 0.74](https://www.dosbox.com/download.php?main=1)
2. Config fájl:
  - helye: **C:\Users\\**[felhasz]**\AppData\Local\DOSBox**
  - utolsó sorai:

```bat
@ECHO OFF
mount C C:\Assembly\_MYOWN
c:
echo You are in C:\Assembly\_MYOWN dir default
echo config file: C:\Users\username\AppData\Local\DOSBox
```

## Program fordítás-futtatás

1) fájl elmentése: **11.asm** nem lehet ékezetes! benne sem!
2) fordítás: **tasm 11**
3) összelinkelés: **tlink 11 /c**
4) futtatás: **11**
