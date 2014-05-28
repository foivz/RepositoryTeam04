CREATE TABLE prava(
id_prava integer primary key,
naziv varchar(45) not null
);

CREATE TABLE korisnici(
id_korisnik integer primary key,
ime varchar(45) not null,
prezime varchar(45) not null,
lozinka varchar(15) not null,
ziro_racun varchar(45) not null,
tel_broj varchar(45) not null,
email varchar(45) not null
);

CREATE TABLE vrsta_artikla(
id_vrsta_artikla integer primary key,
naziv varchar(45) not null
);

CREATE TABLE artikli(
id_artikli integer primary key,
naziv varchar(45) not null,
kolicina int not null,
id_vrsta_artikla integer references vrsta_artikla on delete restrict on update cascade
);

CREATE TABLE oprema(
id_oprema integer primary key,
naziv varchar(45) not null,
opis varchar(200)
);

CREATE TABLE izdatnica(
id_izdatnica integer primary key,
datum datetime not null,
id_korisnik references korisnici on delete restrict on update cascade
);

CREATE TABLE stavke_izdatnice(
id_izdatnica references izdatnica on delete restrict on update cascade,
id_artikli references artikli on delete restrict on update cascade,
kolicina integer not null
);

CREATE TABLE primka(
id_primka integer primary key,
datum datetime not null,
id_korisnik references korisnici on delete restrict on update cascade
);

CREATE TABLE stavke_primke(
id_primka references primka on delete restrict on update cascade,
id_artikli references artikli on delete restrict on update cascade,
kolicina integer not null
);

CREATE TABLE poslovni_partner(
id_poslovni_partner integer primary key,
naziv varchar(45) not null,
ziro_racun varchar(45) not null,
tel_broj varchar(45),
email varchar(45)
);

CREATE TABLE narudzbenica(
id_narudzbenica integer primary key,
datum datetime not null,
id_korisnik references korisnici on delete restrict on update cascade,
id_poslovni_partner references poslovni_partner on delete restrict on update cascade
);

CREATE TABLE stavke_narudzbenice(
id_narudzbenica references narudzbenica on delete restrict on update cascade,
id_artikli references artikli on delete restrict on update cascade,
kolicina integer not null
);

CREATE TABLE racun(
id_racun integer primary key,
datum datetime not null,
id_korisnik references korisnici on delete restrict on update cascade
);

CREATE TABLE stavke_racuna(
id_racun references racun on delete restrict on update cascade,
id_artikli references artikli on delete restrict on update cascade,
kolicina integer not null
);

INSERT INTO prava(naziv) VALUES
('test');

INSERT INTO korisnici(ime, prezime, lozinka, ziro_racun, tel_broj, email) VALUES
('Tomislav', 'Hop', 'lozinka1', 'neki ziro broj1', '0991111111', 'thop@foi.hr'),
('Ivan', 'Hontic', 'lozinka2', 'neki ziro broj2', '0992222222', 'ihontic@foi.hr'),
('Drazen', 'Hrgar', 'lozinka3', 'neki ziro broj3', '0993333333', 'dhrgar@foi.hr');

INSERT INTO vrsta_artikla(naziv) VALUES
('materijal'),
('usluga'),
('proizvod');

INSERT INTO artikli(naziv, kolicina, id_vrsta_artikla) VALUES
('Tinta', 30, 1),
('Tiskanje', 1, 2),
('Knjiga o tiskanju', 300, 3); 

INSERT INTO oprema(naziv, opis) VALUES
('Stroj1','Stroj za tiskanje'),
('Stroj2','Stroj za rezanje');

INSERT INTO izdatnica(datum, id_korisnik) VALUES
('2014-05-05 10:00:00','1'),
('2014-05-05 10:00:00','2');

INSERT INTO stavke_izdatnice(id_izdatnica, id_artikli, kolicina) VALUES
(1,1,20),
(1,2,1),
(1,3,30),
(2,1,10),
(2,2,1),
(2,3,5);

INSERT INTO primka(datum, id_korisnik) VALUES
('2014-05-05 10:00:00','1'),
('2014-05-05 10:00:00','2');

INSERT INTO stavke_primke(id_primka, id_artikli, kolicina) VALUES
(1,1,20),
(1,2,1),
(1,3,30),
(2,1,10),
(2,2,1),
(2,3,5);

INSERT INTO poslovni_partner(naziv, ziro_racun, tel_broj, email) VALUES
('Poslovni partner 1', 'Njegov_broj_racuna1', 'Broj telefona1', 'poslovnip1@email.com'),
('Poslovni partner 2', 'Njegov_broj_racuna2', 'Broj telefona2', 'poslovnip2@email.com'),
('Poslovni partner 3', 'Njegov_broj_racuna3', 'Broj telefona3', 'poslovnip3@email.com');

INSERT INTO narudzbenica(datum, id_korisnik, id_poslovni_partner) VALUES
('2014-05-05 10:00:00','1', 2),
('2014-05-05 10:30:00','1', 1),
('2014-05-05 11:00:00','2', 3);

INSERT INTO stavke_narudzbenice(id_narudzbenica, id_artikli, kolicina) VALUES
(1,1,20),
(1,2,1),
(1,3,30),
(2,1,10),
(2,2,1),
(2,3,5),
(3,1,10),
(3,2,1),
(3,3,5);

INSERT INTO racun(datum, id_korisnik) VALUES
('2014-05-05 10:00:00','1'),
('2014-05-05 10:30:00','1'),
('2014-05-05 11:00:00','2');

INSERT INTO stavke_racuna(id_racun, id_artikli, kolicina) VALUES
(1,1,20),
(1,2,1),
(1,3,30),
(2,1,10),
(2,2,1),
(2,3,5);