n = int(input("Ingrese numero :"))

pares = 0

for i in range(1,n+1):
    print(i)
    if i % 2 == 0:
        pares = pares + i


print(f" Suma de pares : {pares}")
