edad = int(input("Ingrese la edad :"))


if edad >= 18:
    print("Puede votar")
    if edad >= 25:
        print("Puede ser politico")
else:
    print("No puede votar ni ser politico")
