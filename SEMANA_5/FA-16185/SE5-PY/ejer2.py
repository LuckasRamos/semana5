lado1 = int(input("Ingrese lado 1:"))
lado2 = int(input("Ingrese lado 2:"))
lado3 = int(input("Ingrese lado 3:"))

if lado1 == lado2 and lado2 == lado3:
    print("EQUILATERO")
elif lado1 == lado2 or lado2==lado3 or lado3 == lado1:
    print("ISOSCELES")
else:
    print("ESCALENOS")


