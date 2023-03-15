altura = float(input("Digite a sua altura em metros: "))
peso = float(input("Digite o seu peso em kg: "))

imc = peso / altura**2

print("O seu IMC �: {:.2f}".format(imc))

if imc < 18.5:
    print("Voc� est� abaixo do peso ideal.")
elif imc < 25:
    print("Voc� est� no peso ideal.")
elif imc < 30:
    print("Voc� est� com sobrepeso.")
else:
    print("Voc� est� obeso.")
