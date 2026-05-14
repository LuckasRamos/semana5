password = "2007"
intentos = 3

print("\n--------------------------------------")
print("|        Validación de contraseña      |")
print("----------------------------------------\n")

while intentos > 0:
    validar = input("Ingrese su contraseña para ingresar al sistema: ")

    if(validar == password):
        print("Acceso concedido!")
        break
    else:
        intentos-=1
        print(f"Contraseña incorrecta. Intentos restantes ",intentos)

else: print("Acesso denegado. Cerrando programa.... ")