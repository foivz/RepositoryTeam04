using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_PROJEKT
{
    class Podatci
    {
        static int id_korisnik, id_partner, status, id_artikla, id_opreme, id_zaposlenika, id_promjena_artikla, id_partner_dodavanje, id_narudzbenice, klik, idPartnerMail;
        static string ime, prezime, naziv_artikla, partner_naziv, partner_ziro_racun, partner_email, partner_telefonski_broj, nedostaje, nazivPartnerMail;
        static decimal cijena;
        static DateTime dtmMail;

        #region Podatci za izbor partnera

        public static int ID_partner_dodavanje
        {
            get { return id_partner_dodavanje; }
            set { id_partner_dodavanje = value; }
        }

        public static string Partner_naziv
        {
            get { return partner_naziv; }
            set { partner_naziv = value; }
        }

        public static string Partner_ziro_racun
        {
            get { return partner_ziro_racun; }
            set { partner_ziro_racun = value; }
        }

        public static string Partner_email
        {
            get { return partner_email; }
            set { partner_email = value; }
        }

        public static string Partner_telefonski_broj
        {
            get { return partner_telefonski_broj; }
            set { partner_telefonski_broj = value; }
        }

        #endregion

        #region Podatci za izbor stavke
        public static decimal Cijena
        {
            get { return cijena; }
            set { cijena = value; }
        }

        public static int ID_artikla
        {
            get { return id_artikla; }
            set { id_artikla = value; }
        }
        public static string Naziv_artikla
        {
            get { return naziv_artikla; }
            set { naziv_artikla = value; }
        }

        #endregion

        #region Podatci za korisnika
        public static int ID_korisnik 
        {
            get { return id_korisnik; }
            set { id_korisnik=value;}
        }
        public static int Status
        {
            get { return status; }
            set { status = value; }
        }
        public static string Ime
        {
            get { return ime; }
            set { ime = value; }
        }
        public static string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }

        #endregion

        #region Podatci za izmjenu resursa
        public static int ID_partner
        {
            get { return id_partner; }
            set { id_partner = value; }
        }
        public static int ID_oprema
        {
            get { return id_opreme; }
            set { id_opreme = value; }
        }
        public static int ID_promjena_artikla
        {
            get { return id_promjena_artikla; }
            set { id_promjena_artikla = value; }
        }
        public static int ID_zaposlenika
        {
            get { return id_zaposlenika; }
            set { id_zaposlenika = value; }
        }

        #endregion

        public static int ID_narudzbenica
        {
            get { return id_narudzbenice; }
            set { id_narudzbenice = value; }
        }



        public static string Nedostaje 
        {
            get { return nedostaje; }
            set { nedostaje = value; }
        }

        public static int Klik
        {
            get { return klik; }
            set { klik = value; }
        }

        public static string NazivPartnerMail
        {
            get { return nazivPartnerMail; }
            set { nazivPartnerMail = value; }
        }

        public static int IdPartnerMail
        {
            get { return idPartnerMail; }
            set { idPartnerMail = value; }
        }

        public static DateTime DtmMail 
        {
            get { return dtmMail; }
            set { dtmMail = value; }
 
        }
     
       
       
    }
}
