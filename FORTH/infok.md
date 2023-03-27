# FORTH language

```Forth
(LARGE LETTER F)
: STAR 42 EMIT;             (a csillag karakter ANSI Tábla szerint)
: STARS 0 DO STAR LOOP;     (hányszor ismételje a STAR-t)
: MARGIN CR 30 SPACES;      (CR - carriage = kocsivissza, ujsor)
: BLIP MARGIN STAR;
: BAR MARGIN 5 STARS;
: F BAR BLIP BAR BLIP BLIP CR;
F
```

Eredmény:

    *****
    *
    *****
    *
    *

Matek:

3+4 -> 3 4 +

A stackről kivesszük az értéket: .

Jelölés: ( n -- m )
n: paraméter
m: return

| CODE | Paraméter | magyarázat |
| --- | :---: | --- |
| : {simbol} definition; | ( -- ) | szimbolum megadás |
| CR | ( -- ) | ujsor |
| SPACES | ( n -- ) | n db space |
| SPACE | ( -- ) | 1 db space |
| EMIT | ( n -- ) | ANSI tábla alapján átalakít |
| ." xxx" | ( -- ) | Kiírja az "xxx" szöveget |
| . | (n -- ) | Kiír egy számot 1 space után (kiveszi stackről)|
| + | ( n1 n2 -- sum ) | Összeadás |
| - | ( n1 n2 -- diff) | Kivonás |
| * | ( n1 n2 -- prod) | Szorzás |
| / | ( n1 n2 -- quot) | Osztás (egészrészt adja vissza) |
| /MOD | (u1 u2 -- u-rem u-quot) | eredmény, maradék|
| MOD | (u1 u2 -- u-rem) | maradékot ad vissza|

Számolások:

| számolás | FORTH |
| --- | --- |
| c(a+b) | cab+* |
| (3a-b)/ 4 +c | 3a*b-4/c+ |
| (0.5\*ab)/100 | 1 2 / a \* b* 100/ |
| (n+1) /n | n 1 + n / |
| x( 7x+5) | 7x\*5+x* |

Pl programok:
1 yard = 36 inches
yards to inches converter

```Forth
: YARDS>IN 36*;
```

1 foot = 12 inches

```Forth
: FT>IN 12*;
```

Átváltós programok:
deeee megcsinálható igy is:

```Forth
: YARDS  36*;
: FEET 12*
: INCHES ;

10 YARDS 2 FEET + 9 INCHES + .
```

10 \* 36 + 2*12 + 9 = 360+24+9 = 393

22 4 /MOD . .
Ez kiírja, hogy "5 2"

Egyéb műveletek

| művelet | paraméter |
| --- | --- |
| SWAP | (n1 n2 -- n2 n1) |
| DUP | ( n -- n n) |
| OVER | (n1 n2 -- n1 n2 n1) |
| ROT | (n1 n2 n3 -- n2 n3 n1) |
| DROP | ( n -- ) |

Megjegyzés: A ROT csak a felső 3at forgatja meg

DUP * :

| operation | contents of stack |
| --- | --- |
|  | a |
| DUP | a a |
| * | a^2 |

OVER+*

| operation | contents of stack |
| --- | --- |
|  | a b |
| OVER | a b a |
| + | a   (b+a) |
| * | a*(b+a) |

ROT-*

| operation | contents of stack |
| --- | --- |
|  | c b a |
| ROT | b a c |
| - | b (a-c) |
| * | (b*(a-c)) |

Teljes stack kiiratása:
.S

Érdekesség: mindig 0 lesz az első karakter

Feladatok:

1) a b c -> c b a

    ```Forth
        SWAP ROT
    ```

2) OVER func without OVER

    a b -> a b a
    SWAP DUP ROT ROT
    ba   baa aab aba

3) Write opposite `ROT` function: `<ROT` ami ezt csinálja: a b c -> c a b

    ```Forth
        `:<ROT ROT ROT;`
    ```

4) (n+1)/n (n -- result)

    ```Forth
        :negyes DUP 1 + SWAP / ;
    ```

5) x(7x+5) ( x -- result)

    ```Forth
        :otos DUP 7*5+*;
    ```

6) 9a^2 - ba ( a b -- result)

    ```Forth
        :hatos OVER DUP * 9* ROT ROT *-
    ```

    Számolás:
        a b
        over
        a b a
        dup
        a b a a
        *
        a b a^2
        9*
        a b a^2*9
        rot
        rot
        a^2*9 a b
        *-

Megoldás:

```Forth
OVER 9* SWAP -*
```

    a b a*9
    a a*9 b
    a 9a-b
    (9a-b)a

Érdemes előbb egyszerűsíteni a számolást!

Comment:

    () -jelbe kell tenni
