CREATE SCHEMA TugasAkhir;

use TugasAkhir;

Create table TBMahasiswa (
	NIM bigint primary key,
    Nama  varchar(50),
    Kelamin varchar(50),
	Studi  varchar(50),
    Predikat varchar(50),
    IPK float(10),
    gambar varchar(200)
);

select * from TBMahasiswa;

INSERT INTO TBMahasiswa (NIM, Nama, Kelamin, Studi, Predikat, IPK, gambar)
VALUES (2023001001, 'Budi Santoso', 'Laki-laki', 'Teknik Informatika', 'Sangat Memuaskan', 3.75, "test");

SELECT Nama, IPK FROM TBMahasiswa WHERE Studi LIKE "Informatika" ORDER BY Nama;