#include <iostream>
#include <windows.h>

#pragma execution_character_set("utf-8")

using namespace std;
void fakt() {
    bool hiba;
    int n;
    int fakt = 1;
    do {
        cout << "Adj meg egy szamot:";
        cin >> n;
        hiba = n < 0;
        if (hiba) {
            cout << "Rossz szamot adtal meg! Add meg ujra!" << endl;
        }
    } while (hiba);

    for (int i = 1; i <= n; ++i)
        fakt *= i;
    cout << "Az " << n << " faktorialisa: " << fakt;
}

int fakt(int n) {
    int fakt = 1;
    for (int i = 1; i <= n; ++i)
        fakt *= i;
    return fakt;
}

int main()
{
    //fakt();

    int szamok[10];

    for (int i = 0; i < sizeof(szamok) / sizeof(int); ++i) {
        szamok[i] = fakt(i);
    }

    for (int i = 0; i < sizeof(szamok) / sizeof(int); ++i) {
        cout << szamok[i] << endl ;
    }

    cout << "----------" << endl;
    cout << szamok << endl;
    cout << szamok[0]<<endl;
    cout << szamok[5] << endl;
    cout << 5[szamok] << endl;
    cout << *szamok << endl;
    cout << *(szamok+5) << endl;
    cout << *(5+ szamok) << endl;
    cout << 5[szamok] << endl;

    return 0;
}