# //Escreva um programa que informa o troco a ser recebido pelo cliente, por exemplo:

# //-Valor final da compra: R$ 328,00
# //- Pagamento: R$ 400,00
# //- Troco:
# //  -1 nota de 2 reais
# //  - 2 notas de 10 reais
# //  - 2 notas de 50 reais

print("Calcular o troco:")
compra = input("Informe o valor da compra: ")
compra = float(compra.replace(",", "."))

pagamento = input("Informe o valor pago pelo cliente: ")
pagamento = float(pagamento.replace(",", "."))

troco = pagamento - compra

notas200 = 0
notas100 = 0
notas50 = 0
notas20 = 0
notas10 = 0
notas5 = 0
notas2 = 0
moedas1 = 0
moedas50 = 0
moedas25 = 0
moedas10 = 0
moedas5 = 0

while troco >= 200:
    notas200 +=1
    troco -= 200

while troco >= 100:
    notas100 +=1
    troco -= 100

while troco >= 50:
    notas50 +=1
    troco -= 50

while troco >= 20:
    notas20 +=1
    troco -= 20

while troco >= 10:
    notas10 +=1
    troco -= 10

while troco >= 5:
    notas5 +=1
    troco -= 5

while troco >= 2:
    notas2 +=1
    troco -= 2

while troco >= 1.00:
    moedas1 += 1
    troco -= 1.00

while troco >= 0.50:
    moedas50 +=1
    troco -= 0.50

while troco >= 0.25:
    moedas25 +=1
    troco -= 0.25

while troco >= 0.10:
    moedas10 +=1
    troco -= 0.10

while troco >= 0.05:
    moedas5 +=1
    troco -= 0.05

print("Notas a ser entregue ao cliente: ")
print("NOTAS:")
if notas200 > 0:
    print("Notas de R$200: ", notas200)
if notas100 > 0:
    print("Notas de R$100: ", notas100)
if notas50 > 0:
    print("Notas de  R$50: ", notas50)
if notas20 > 0:
    print("Notas de  R$20: ", notas20)
if notas10 > 0:
    print("Notas de  R$10: ", notas10)
if notas5 > 0:
    print("Notas de   R$5: ", notas5)
if notas2 > 0:
    print("Notas de   R$2: ", notas2)
print("MOEDAS:")
if moedas1 > 0:
    print("Moedas de  R$1: ", moedas1)
if moedas50 > 0:
    print("Moedas de R$0,50: ", moedas50)
if moedas25 > 0:
    print("Moedas de R$0,25: ", moedas25)
if moedas10 > 0:
    print("Moedas de R$0,10: ", moedas10)
if moedas5 > 0:
    print("Moedas de R$0,05: ", moedas5)