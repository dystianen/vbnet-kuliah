print('======================================================')
print('Nama: Dystian En Yusgiantoro, NIM: 411221165')
print('======================================================')

print('Jurusan dan Lokasi kampus')

majors_locations = [
    ('Sistem Informasi', 'Tanjung Duren'),
    ('Sistem Informasi', 'Kranggan'),
    ('Teknik Informatika', 'Tanjung Duren'),
    ('Teknik Informatika', 'Kranggan')
]

for i, (major, location) in enumerate(majors_locations):
    print(i + 1, major, "-", location)

print('===============================')
name = input('Nama Lengkap ?: ')
major_location = int(input('Pilih Jurusan dan Lokasi Kampus ?: '))
print('===============================')

if major_location > 0 and major_location <= len(majors_locations):
    selected_major, selected_location = majors_locations[major_location - 1]
    print('a.', selected_major)
    print('b.', selected_location)
