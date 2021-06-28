-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 28 Jun 2021 pada 19.06
-- Versi server: 10.4.19-MariaDB
-- Versi PHP: 7.3.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `tugasakhir`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `admin`
--

CREATE TABLE `admin` (
  `libraryId` varchar(30) NOT NULL,
  `password` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `admin`
--

INSERT INTO `admin` (`libraryId`, `password`) VALUES
('admin', 'admin');

-- --------------------------------------------------------

--
-- Struktur dari tabel `buku`
--

CREATE TABLE `buku` (
  `id_buku` varchar(255) NOT NULL,
  `judul_buku` varchar(255) NOT NULL,
  `penerbit` varchar(255) NOT NULL,
  `stok` int(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `buku`
--

INSERT INTO `buku` (`id_buku`, `judul_buku`, `penerbit`, `stok`) VALUES
('13', 'Dilan', 'Pidi Baiq', 3),
('22', 'Ayam Kampung', 'Pt.Sabung Ayam', 2),
('289', 'benarjuga', 'kayla', 19),
('299', 'benar', 'danda', 2),
('66', 'Cantik', 'Dannyla', 10),
('69', 'Rudy Habibie', 'Gramedia', 2),
('876655', 'salahjuga', 'kayla', 987),
('87666', 'salah', 'danda', 999);

-- --------------------------------------------------------

--
-- Struktur dari tabel `login_admin`
--

CREATE TABLE `login_admin` (
  `libraryId` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Struktur dari tabel `log_in`
--

CREATE TABLE `log_in` (
  `LibId` varchar(255) NOT NULL,
  `nama` varchar(255) NOT NULL,
  `noHp` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `tgl_lahir` date NOT NULL,
  `password` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Struktur dari tabel `member`
--

CREATE TABLE `member` (
  `libraryId` varchar(30) NOT NULL,
  `nama` varchar(30) DEFAULT NULL,
  `email` varchar(30) DEFAULT NULL,
  `noHp` varchar(15) DEFAULT NULL,
  `password` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `member`
--

INSERT INTO `member` (`libraryId`, `nama`, `email`, `noHp`, `password`) VALUES
('0601', 'Alif', 'Alif@gmal.com', '082267396716', '12345'),
('060122', 'kylnd', 'dandakomang@gmail.com', '082267396716', '01122001'),
('1206', 'dondon', 'damksdkm@gmail.com', '0908982139', '01122001'),
('1234', 'dora', 'bahsb@gmail.com', '9184071240810', '01122001'),
('2212', 'dada', 'dasdsa@gmail.com', '098765543', '01122001'),
('3444', 'ddas', 'dads@gmail.com', '89012830982', '01122001'),
('666666', 'lolox', 'lolox@gmail.com', '9988776262', '12345'),
('7777', 'Priyo', 'asas@gmail.com', '12414315235', '01122001');

--
-- Trigger `member`
--
DELIMITER $$
CREATE TRIGGER `updatenamapeminjam` AFTER UPDATE ON `member` FOR EACH ROW UPDATE peminjaman SET namaPeminjam=new.nama
WHERE libraryId = new.libraryId
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Struktur dari tabel `peminjaman`
--

CREATE TABLE `peminjaman` (
  `libraryId` varchar(255) NOT NULL,
  `namaPeminjam` varchar(255) NOT NULL,
  `id_buku` int(255) NOT NULL,
  `namaBuku` varchar(255) NOT NULL,
  `tgl_pinjam` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `peminjaman`
--

INSERT INTO `peminjaman` (`libraryId`, `namaPeminjam`, `id_buku`, `namaBuku`, `tgl_pinjam`) VALUES
('7777', 'Priyo', 876655, 'salahjuga', '2021-06-28');

--
-- Trigger `peminjaman`
--
DELIMITER $$
CREATE TRIGGER `insertPengembalian` AFTER DELETE ON `peminjaman` FOR EACH ROW INSERT INTO pengembalian
    set libraryId = OLD.libraryId,
    namaPeminjam = OLD.namaPeminjam,
    id_buku = OLD.id_buku,
    namaBuku = OLD.namaBuku,
    tgl_pinjam = NOW()
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `kembalikanbukut` AFTER DELETE ON `peminjaman` FOR EACH ROW UPDATE buku SET stok=stok+1
WHERE judul_buku = OLD.namaBuku
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `setok` AFTER INSERT ON `peminjaman` FOR EACH ROW UPDATE buku SET stok=stok-1
WHERE judul_buku = NEW.namaBuku
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Struktur dari tabel `pengembalian`
--

CREATE TABLE `pengembalian` (
  `libraryId` varchar(255) NOT NULL,
  `namaPeminjam` varchar(255) NOT NULL,
  `id_buku` int(255) NOT NULL,
  `namaBuku` varchar(255) NOT NULL,
  `tgl_pinjam` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `pengembalian`
--

INSERT INTO `pengembalian` (`libraryId`, `namaPeminjam`, `id_buku`, `namaBuku`, `tgl_pinjam`) VALUES
('1206', 'dondon', 289, 'benarjuga', '2021-06-28'),
('0601', 'Alif', 876655, 'salahjuga', '2021-06-28');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`libraryId`);

--
-- Indeks untuk tabel `buku`
--
ALTER TABLE `buku`
  ADD PRIMARY KEY (`id_buku`);

--
-- Indeks untuk tabel `login_admin`
--
ALTER TABLE `login_admin`
  ADD PRIMARY KEY (`libraryId`);

--
-- Indeks untuk tabel `log_in`
--
ALTER TABLE `log_in`
  ADD PRIMARY KEY (`LibId`);

--
-- Indeks untuk tabel `member`
--
ALTER TABLE `member`
  ADD PRIMARY KEY (`libraryId`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
