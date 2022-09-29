"""
    Vytvořte modul vectors.py.
    V něm bude definice třídy MyVector.
    Konstruktor bude akceptovat (navíc k self) jeden parametr, kterým bude seznam s prvky vektoru.
    Metoda get_vector(self) navrátí seznam obsahující prvky vektoru.
    Pomocí metody __mul__(self,other) implementujte skalární součin dvou objektů typu MyVector. Výstupem je tedy skalár (jedno číslo).
    Soubor vectors.py nesmí importovat jiné moduly.
    Soubor nahrajte do BRUTE do požadovaného termínu.
    BRUTE vám kód ihned ohodnotí, případně několik sekund počkejte.
    Za správně vyřešenou úlohu získáte až 2 body.
"""
from vectors import MyVector

if __name__ == "__main__":
    vec1 = MyVector([1,2,3]) # vektory mohou byt i jine dimenze nez 3!
    vec2 = MyVector([3,4,5]) 
    print(vec1.get_vector())
    print(vec2.get_vector()) # priklad ziskani seznamu
    dot_product = vec1*vec2  # vypocet skalarniho soucinu, pretizeny operator *, vola se __mul__
    print(dot_product)       # jen kontrolni vypis