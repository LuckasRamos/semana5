cant = int(input("Ingrese la cantidad de numeros :"))
ceros = 0
pares = 0
impares = 0
for i in range(1, cant + 1):
    n = int(input(f"Ingresar numero {i} :"))

    if n == 0:
        ceros += 1
        #ceros = ceros +  i
    elif n % 2 == 0:
        pares += 1
    else:
        impares += 1

print("\nRESULTADOS")
print(f"Cantidad de pares : {pares}")
print(f"Cantidad de impares : {impares}")
print(f"Cantidad de ceros : {ceros}")

