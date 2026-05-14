filas = int(input("Ingres filas: "))
columnas = int(input("Ingres columnas: "))

i=0
while i < filas:
    j=0
    while j < columnas:
        print("*", end= " ")
        j+=1
    print()
    i+=1