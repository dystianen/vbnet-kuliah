print('======================================================')
print('Dibuat oleh : Dystian En Yusgiantoro, NIM: 411221165')
print('======================================================')

print()
print('Menjumlahkan data')
jumlah_data = int(input("Masukkan jumlah data: "))

total = 0

for i in range(jumlah_data):
    data = int(input("Data ke-{}: ".format(i + 1)))
    total += data

print()
print("Hasil=", total)