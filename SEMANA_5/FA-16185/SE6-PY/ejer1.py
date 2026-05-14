num = int(input("Ingrese un número:"))

while num <=0:
     num = int(input("Número invalido. Ingrese un número:"))

i=1 

while i<=12:
     print(f"{num}x{i}={num * 1}")
     i+=1