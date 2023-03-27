"""
Feladat:
Rock, Paper, Scrissor játék
1 sor a fájlban= 1 kör

Ha mi mutatjuk őket, akkor sorban: A,B,C a jele
Ha az ellenfél: X,Y,Z

Ha bármelyiket felmutatjuk: van értékeik: sorban (1,2,3)
    mindenképp megkapjuk ezt az értéket

Aki nyer +6 pont

bemenet:

A X
A Y
B Z

"""


m = {'A' => 0 , 'B' => 1, 'C'=> 2, 'X' => 0, 'Y' => 1, 'Z' => 2}
v= [1,2,3]
f= File.open("file")
sum = f.readlines # soronként egy lista
        .map(&:chomp) # & : tegye háttérbe; : jel azt jelenti, hogy a split függvényt csak 1szer menti el a memóriába
        .map(&:split) # ez egy egyszerűsítése a { } résznek
        .map{ |n| n.map{ |i| m[i]}} # {} jel a "kódrész jön" -t jelenti
                # ez egy egyszerűsí tett lambda hivás
                # map{ |n| n.chomp} ekkor minden elemre hivjuk meg a chomp függvényt
                # ennek egyszerűsitése a map(&:chomp)
        .map{ |n| ( n[0] == n[1] ) ? 3+v[n[1]] :
                (v[n[0]-1] == v[n[1]] )? v[n[1]] : 6+ v[n[1]] }.sum
                # ? : operátor ami C-ben is: "if else"
f.close()

puts sum    #kiirja a végeredményt
        # másik kiirási mód: p minden értéket kiir (uj sor karaktert is)
        # van még kiirásra a print, de nem szokták használni