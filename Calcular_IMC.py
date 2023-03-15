altura = float(input("Digite a sua altura em metros: "))
peso = float(input("Digite o seu peso em kg: "))

imc = peso / altura**2

print("O seu IMC é: {:.2f}".format(imc))

if imc < 18.5:
    print("Você está abaixo do peso ideal.")
elif imc < 25:
    print("Você está no peso ideal.")
elif imc < 30:
    print("Você está com sobrepeso.")
else:
    print("Você está obeso.")
