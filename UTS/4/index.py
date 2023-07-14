print('======================================================')
print('Dibuat oleh : Dystian En Yusgiantoro, NIM: 411221165')
print('======================================================')

start = int(input("Mulai dari angka: "))
end = int(input("Sampai angka: "))
exponent = int(input("Nilai pangkat: "))

for num in range(start, end+1):
    result = num ** exponent
    print("{}^{} = {}".format(num, exponent, result))

    