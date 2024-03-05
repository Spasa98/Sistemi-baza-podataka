using NHibernate;
using ObezbedjenjeClassLibrary.DTOs;
using ObezbedjenjeClassLibrary.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObezbedjenjeClassLibrary
{
    public class DTOManager
    {
        #region Zaposleni + M + TL + FO

        public static List<Zaposleni_View> ReadSveZaposlene()
        {
            List<Zaposleni_View> zaposleni = new List<Zaposleni_View>();
            try
            {
                ISession s = DataLayer.GetSession();

                List<Zaposleni> sviZaposleni = s.Query<Zaposleni>()
                                                .ToList();

                foreach (Zaposleni z in sviZaposleni)
                {
                    zaposleni.Add(new Zaposleni_View(z));
                }

                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
            return zaposleni;
        }

        #region Menadzer

        public static List<Menadzer_View> ReadSveMenadzere()
        {
            List<Menadzer_View> menadzeri = new List<Menadzer_View>();
            try
            {
                ISession s = DataLayer.GetSession();

                List<Menadzer> sviMenadzeri = s.Query<Menadzer>()
                                               .ToList();

                foreach (Menadzer m in sviMenadzeri)
                {
                    menadzeri.Add(new Menadzer_View(m));
                }

                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
            return menadzeri;
        }

        public static void CreateMenadzer(int idRC, Menadzer_View m)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Regionalni_Centar rc = s.Get<Regionalni_Centar>(idRC);
                Menadzer men = new Menadzer
                {
                    JMBG = m.JMBG,
                    Ime = m.Ime,
                    Prezime = m.Prezime,
                    Pol = m.Pol,
                    Datum_Rodjenja = m.Datum_Rodjenja,
                    Regionalni_Centar = rc
                };

                s.Save(men);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
        }

        public static void UpdateMenadzer(int idRCNovi, Menadzer_View m)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Regionalni_Centar rc = s.Get<Regionalni_Centar>(idRCNovi);
                Menadzer men = s.Get<Menadzer>(m.ID);

                men.Regionalni_Centar = rc;

                s.SaveOrUpdate(men);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
        }

        public static void DeleteMenadzer(int idM)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Menadzer men = s.Get<Menadzer>(idM);

                s.Delete(men);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
        }

        #endregion

        #region TehnickoLice

        public static List<Tehnicko_Lice_View> ReadSvaTehnickaLica()
        {
            List<Tehnicko_Lice_View> lica = new List<Tehnicko_Lice_View>();
            try
            {
                ISession s = DataLayer.GetSession();

                List<Tehnicko_Lice> svaLica = s.Query<Tehnicko_Lice>()
                                               .ToList();

                foreach (Tehnicko_Lice l in svaLica)
                {
                    lica.Add(new Tehnicko_Lice_View(l));
                }

                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
            return lica;
        }

        public static void CreateTehnickoLice(Tehnicko_Lice_View lice)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Tehnicko_Lice tehLice = new Tehnicko_Lice
                {
                    JMBG = lice.JMBG,
                    Ime = lice.Ime,
                    Prezime = lice.Prezime,
                    Pol = lice.Pol,
                    Datum_Rodjenja = lice.Datum_Rodjenja,
                    Oblast_Tehnike = lice.Oblast_Tehnike,
                    Strucna_Sprema = lice.Strucna_Sprema
                };

                s.Save(tehLice);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
        }

        public static void UpdateTehnickoLice(Tehnicko_Lice_View tl, string ot, string ss)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Tehnicko_Lice t = s.Get<Tehnicko_Lice>(tl.ID);

                t.Oblast_Tehnike = ot;
                t.Strucna_Sprema = ss;

                s.SaveOrUpdate(t);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
        }

        public static void DeleteTehnickoLice(int idTL)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Tehnicko_Lice tl = s.Get<Tehnicko_Lice>(idTL);

                s.Delete(tl);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
        }

        #endregion

        #region FizickoObezbedjenje

        public static List<Fizicko_Obezbedjenje_View> ReadSvaFizickaObezbedjenja()
        {
            List<Fizicko_Obezbedjenje_View> obezb = new List<Fizicko_Obezbedjenje_View>();
            try
            {
                ISession s = DataLayer.GetSession();

                List<Fizicko_Obezbedjenje> svaObezb = s.Query<Fizicko_Obezbedjenje>()
                                                       .ToList();

                foreach (Fizicko_Obezbedjenje fo in svaObezb)
                {
                    obezb.Add(new Fizicko_Obezbedjenje_View(fo));
                }

                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
            return obezb;
        }

        public static void CreateFizickoObezbedjenje(Fizicko_Obezbedjenje_View fo, int idEkipa)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Ekipa e = s.Get<Ekipa>(idEkipa);
                Fizicko_Obezbedjenje obezb = new Fizicko_Obezbedjenje
                {
                    JMBG = fo.JMBG,
                    Ime = fo.Ime,
                    Prezime = fo.Prezime,
                    Pol = fo.Pol,
                    Datum_Rodjenja = fo.Datum_Rodjenja,
                    Borilacka_Vestina = fo.Borilacka_Vestina,
                    Vodja_Flag = fo.Vodja_Flag,
                    Ekipa = e
                };

                s.Save(obezb);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
        }

        public static void UpdateFizickoObezbedjenje(Fizicko_Obezbedjenje_View fo, string bor, bool vodja)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Fizicko_Obezbedjenje f = s.Get<Fizicko_Obezbedjenje>(fo.ID);

                f.Borilacka_Vestina = bor;
                f.Vodja_Flag = vodja;

                s.SaveOrUpdate(f);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
        }

        public static void DeleteFizickoObezbedjenje(int idFiz)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Fizicko_Obezbedjenje fo = s.Get<Fizicko_Obezbedjenje>(idFiz);

                s.Delete(fo);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
        }

        #endregion

        #endregion

        #region RegionalniCentar

        public static List<Regionalni_Centar_View> ReadSveRegCentre()
        {
            List<Regionalni_Centar_View> regcen = new List<Regionalni_Centar_View>();
            try
            {
                ISession s = DataLayer.GetSession();

                List<Regionalni_Centar> sviRegC = s.Query<Regionalni_Centar>()
                                                   .ToList();

                foreach (Regionalni_Centar rc in sviRegC)
                {
                    regcen.Add(new Regionalni_Centar_View(rc));
                }

                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
            return regcen;
        }

        public static void CreateRegionalniCentar(Regionalni_Centar_View rc)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Regionalni_Centar regcen = new Regionalni_Centar
                {
                    Adresa = rc.Adresa
                };

                s.Save(regcen);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
        }

        public static void UpdateRegionalniCentar(Regionalni_Centar_View rc, string novaAdr)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Regionalni_Centar noviRC = s.Get<Regionalni_Centar>(rc.ID);

                noviRC.Adresa = novaAdr;

                s.SaveOrUpdate(noviRC);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
        }

        public static void DeleteRegionalniCentar(int idRC)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Regionalni_Centar rc = s.Get<Regionalni_Centar>(idRC);

                s.Delete(rc);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
        }

        #endregion

        #region TelefonRC

        public static List<Telefon_RC_View> ReadSveTelefoneRC()
        {
            List<Telefon_RC_View> telefoni = new List<Telefon_RC_View>();
            try
            {
                ISession s = DataLayer.GetSession();

                List<Telefon_RC> sviTelefoni = s.Query<Telefon_RC>()
                                                .ToList();

                foreach (Telefon_RC tel in sviTelefoni)
                {
                    telefoni.Add(new Telefon_RC_View(tel));
                }

                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
            return telefoni;
        }

        public static List<Telefon_RC_View> ReadSveTelefoneJednogRC(int idRC)
        {
            List<Telefon_RC_View> telefoni = new List<Telefon_RC_View>();
            try
            {
                ISession s = DataLayer.GetSession();

                Regionalni_Centar rc = s.Get<Regionalni_Centar>(idRC);

                foreach (Telefon_RC tel in rc.Telefoni_RC)
                {
                    telefoni.Add(new Telefon_RC_View(tel));
                }

                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
            return telefoni;
        }

        public static void CreateTelefonRC(Telefon_RC_View tel, int idRegCen)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Regionalni_Centar regcen = s.Get<Regionalni_Centar>(idRegCen);

                Telefon_RC broj = new Telefon_RC
                {
                    Telefon = tel.Telefon,
                    Regionalni_Centar = regcen
                };

                s.Save(broj);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
        }

        public static void UpdateTelefonRC(Telefon_RC_View t)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Telefon_RC noviBr = s.Get<Telefon_RC>(t.ID);

                noviBr.Telefon = t.Telefon;

                s.SaveOrUpdate(noviBr);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
        }

        public static void DeleteTelefonRC(int idTel)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Telefon_RC t = s.Get<Telefon_RC>(idTel);

                s.Delete(t);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
        }

        #endregion

        #region Grad

        public static List<Grad_View> ReadSveGradove()
        {
            List<Grad_View> gradovi = new List<Grad_View>();
            try
            {
                ISession s = DataLayer.GetSession();

                List<Grad> sviGradovi = s.Query<Grad>()
                                          .ToList();

                foreach (Grad g in sviGradovi)
                {
                    gradovi.Add(new Grad_View(g));
                }

                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
            return gradovi;
        }

        public static void CreateGrad(Grad_View g, int idMenadzera, int idRegCen)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Regionalni_Centar regcen = s.Get<Regionalni_Centar>(idRegCen);
                Menadzer men = s.Get<Menadzer>(idMenadzera);
                Grad grad = new Grad
                {
                    Naziv = g.Naziv,
                    Menadzer = men,
                    Regionalni_Centar = regcen
                };

                s.Save(grad);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
        }

        public static void UpdateGrad(Grad_View g, string naziv)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Grad noviGrad = s.Get<Grad>(g.ID);

                noviGrad.Naziv = naziv;

                s.SaveOrUpdate(noviGrad);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
        }

        public static void DeleteGrad(int idG)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Grad g = s.Get<Grad>(idG);

                s.Delete(g);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
        }

        #endregion

        #region Vozilo

        public static List<Vozilo_View> ReadSvaVozila()
        {
            List<Vozilo_View> vozila = new List<Vozilo_View>();
            try
            {
                ISession s = DataLayer.GetSession();

                List<Vozilo> svaVozila = s.Query<Vozilo>()
                                          .ToList();

                foreach (Vozilo v in svaVozila)
                {
                    vozila.Add(new Vozilo_View(v));
                }

                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
            return vozila;
        }

        public static void CreateVozilo(Vozilo_View v, int idRegCen)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Regionalni_Centar regcen = s.Get<Regionalni_Centar>(idRegCen);
                Vozilo vozilo = new Vozilo
                {
                    Registarska_Oznaka = v.Registarska_Oznaka,
                    Model = v.Model,
                    Proizvodjac = v.Proizvodjac,
                    Tip = v.Tip,
                    Boja = v.Boja,
                    Regionalni_Centar = regcen
                };

                s.Save(vozilo);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
        }

        public static void UpdateVozilo(Vozilo_View v)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Vozilo novoVozilo = s.Get<Vozilo>(v.ID);
                Regionalni_Centar rc = s.Query<Regionalni_Centar>()
                                        .Where(r => r.ID == v.Regionalni_Centar.ID)
                                        .Select(r => r).FirstOrDefault();

                novoVozilo.Registarska_Oznaka = v.Registarska_Oznaka;
                novoVozilo.Proizvodjac = v.Proizvodjac;
                novoVozilo.Model = v.Model;
                novoVozilo.Tip = v.Tip;
                novoVozilo.Boja = v.Boja;
                novoVozilo.Regionalni_Centar = rc;

                s.SaveOrUpdate(novoVozilo);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
        }

        public static void DeleteVozilo(int idV)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Vozilo v = s.Get<Vozilo>(idV);

                s.Delete(v);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
        }

        #endregion

        #region Smena

        public static List<Smena_View> ReadSveSmene()
        {
            List<Smena_View> smene = new List<Smena_View>();
            try
            {
                ISession s = DataLayer.GetSession();

                List<Smena> sveSmene = s.Query<Smena>()
                                         .ToList();

                foreach (Smena sm in sveSmene)
                {
                    smene.Add(new Smena_View(sm));
                }

                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
            return smene;
        }

        public static void CreateSmena(Smena_View sm)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Smena smena = new Smena
                {
                    Vreme_Pocetka = sm.Vreme_Pocetka,
                    Vreme_Kraja = sm.Vreme_Kraja
                };

                s.Save(smena);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
        }

        public static void UpdateSmena(Smena_View sm)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Smena novaSmena = s.Get<Smena>(sm.ID);

                novaSmena.Vreme_Pocetka = sm.Vreme_Pocetka;
                novaSmena.Vreme_Kraja = sm.Vreme_Kraja;

                s.SaveOrUpdate(novaSmena);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
        }

        public static void DeleteSmena(int idS)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Smena sm = s.Get<Smena>(idS);

                s.Delete(sm);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
        }

        #endregion

        #region AlarmniSistem

        public static List<Alarmni_Sistem_View> ReadSveAlarmneSisteme()
        {
            List<Alarmni_Sistem_View> sistemi = new List<Alarmni_Sistem_View>();
            try
            {
                ISession s = DataLayer.GetSession();

                List<Alarmni_Sistem> sviSistemi = s.Query<Alarmni_Sistem>()
                                                    .ToList();

                foreach (Alarmni_Sistem als in sviSistemi)
                {
                    sistemi.Add(new Alarmni_Sistem_View(als));
                }

                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
            return sistemi;
        }

        public static void CreateAlarmniSistem(Alarmni_Sistem_View als)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Alarmni_Sistem sistem = new Alarmni_Sistem
                {
                    Proizvodjac = als.Proizvodjac,
                    Datum_Instalacije = als.Datum_Instalacije,
                    Godina_Proizvodnje = als.Godina_Proizvodnje,
                    DTO_Flag = als.DTO_Flag,
                    Vertikalna_Rezolucija = als.Vertikalna_Rezolucija,
                    Horizontalna_Rezolucija = als.Horizontalna_Rezolucija,
                    US_Flag = als.US_Flag,
                    OpsegFrekfencije = als.OpsegFrekfencije,
                    DP_Flag = als.DP_Flag,
                    Osetljivost = als.Osetljivost
                };

                s.Save(sistem);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
        }

        public static void UpdateAlarmniSistem(Alarmni_Sistem_View als)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Alarmni_Sistem noviSistem = s.Get<Alarmni_Sistem>(als.ID);

                noviSistem.Proizvodjac = als.Proizvodjac;
                noviSistem.Datum_Instalacije = als.Datum_Instalacije;
                noviSistem.Godina_Proizvodnje = als.Godina_Proizvodnje;
                noviSistem.DTO_Flag = als.DTO_Flag;
                noviSistem.Vertikalna_Rezolucija = als.Vertikalna_Rezolucija;
                noviSistem.Horizontalna_Rezolucija = als.Horizontalna_Rezolucija;
                noviSistem.US_Flag = als.US_Flag;
                noviSistem.OpsegFrekfencije = als.OpsegFrekfencije;
                noviSistem.DP_Flag = als.DP_Flag;
                noviSistem.Osetljivost = als.Osetljivost;

                s.SaveOrUpdate(noviSistem);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
        }

        public static void DeleteAlarmniSistem(int idALS)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Alarmni_Sistem als = s.Get<Alarmni_Sistem>(idALS);

                s.Delete(als);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
        }

        #endregion

        #region Ekipa

        public static List<Ekipa_View> ReadSveEkipe()
        {
            List<Ekipa_View> ekipe = new List<Ekipa_View>();
            try
            {
                ISession s = DataLayer.GetSession();

                List<Ekipa> sveEkipe = s.Query<Ekipa>()
                                         .ToList();

                foreach (Ekipa ek in sveEkipe)
                {
                    var ekipa = new Ekipa_View(ek);
                    ekipe.Add(ekipa);
                }

                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
            return ekipe;
        }

        public static void CreateEkipa(Ekipa_View ek)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Ekipa ekipa = new Ekipa
                {
                    Naziv = ek.Naziv
                };

                s.Save(ekipa);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
        }

        public static void UpdateEkipa(Ekipa_View ek)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Ekipa novaEkipa = s.Get<Ekipa>(ek.ID);

                novaEkipa.Naziv = ek.Naziv;

                s.SaveOrUpdate(novaEkipa);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
        }

        public static void DeleteEkipa(int idE)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Ekipa ek = s.Get<Ekipa>(idE);

                s.Delete(ek);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
        }

        #endregion

        #region Objekat

        public static List<Objekat_View> ReadSveObjekte()
        {
            List<Objekat_View> objekti = new List<Objekat_View>();
            try
            {
                ISession s = DataLayer.GetSession();

                List<Objekat> sviObj = s.Query<Objekat>()
                                         .ToList();

                foreach (Objekat ob in sviObj)
                {
                    objekti.Add(new Objekat_View(ob));
                }

                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
            return objekti;
        }

        public static void CreateObjekat(Objekat_View ob)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Objekat noviObj = new Objekat
                {
                    Adresa = ob.Adresa,
                    Tip = ob.Tip,
                    Povrsina = ob.Povrsina
                };

                Alarmni_Sistem noviAls = new Alarmni_Sistem
                {
                    Proizvodjac = ob.Alarmni_Sistem.Proizvodjac,
                    Datum_Instalacije = ob.Alarmni_Sistem.Datum_Instalacije,
                    Godina_Proizvodnje = ob.Alarmni_Sistem.Godina_Proizvodnje,
                    DTO_Flag = ob.Alarmni_Sistem.DTO_Flag,
                    Vertikalna_Rezolucija = ob.Alarmni_Sistem.Vertikalna_Rezolucija,
                    Horizontalna_Rezolucija = ob.Alarmni_Sistem.Horizontalna_Rezolucija,
                    US_Flag = ob.Alarmni_Sistem.US_Flag,
                    OpsegFrekfencije = ob.Alarmni_Sistem.OpsegFrekfencije,
                    DP_Flag = ob.Alarmni_Sistem.DP_Flag,
                    Osetljivost = ob.Alarmni_Sistem.Osetljivost
                };

                noviObj.Alarmni_Sistem = noviAls;

                s.Save(noviObj);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
        }

        public static void UpdateObjekat(Objekat_View ob)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Objekat noviObj = s.Get<Objekat>(ob.ID);

                noviObj.Adresa = ob.Adresa;
                noviObj.Tip = ob.Tip;
                noviObj.Povrsina = ob.Povrsina;


                s.SaveOrUpdate(noviObj);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
        }

        public static void DeleteObjekat(int idO)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Objekat ob = s.Get<Objekat>(idO);

                s.Delete(ob);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
        }

        #endregion

        #region TelefonO

        public static List<Telefon_O_View> ReadSveTelefoneO()
        {
            List<Telefon_O_View> telefoni = new List<Telefon_O_View>();
            try
            {
                ISession s = DataLayer.GetSession();

                List<Telefon_O> sviTelefoni = s.Query<Telefon_O>()
                                                .ToList();

                foreach (Telefon_O tel in sviTelefoni)
                {
                    telefoni.Add(new Telefon_O_View(tel));
                }

                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
            return telefoni;
        }

        public static List<Telefon_O_View> ReadSveTelefoneJednogO(int idO)
        {
            List<Telefon_O_View> telefoni = new List<Telefon_O_View>();
            try
            {
                ISession s = DataLayer.GetSession();

                Objekat obj = s.Get<Objekat>(idO);

                foreach (Telefon_O tel in obj.Telefoni_Objekta)
                {
                    telefoni.Add(new Telefon_O_View(tel));
                }

                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
            return telefoni;
        }

        public static void CreateTelefonO(Telefon_O_View tel, int idO)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Objekat obj = s.Get<Objekat>(idO);

                Telefon_O broj = new Telefon_O
                {
                    Telefon = tel.Telefon,
                    Objekat = obj
                };

                s.Save(broj);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
        }

        public static void UpdateTelefonO(Telefon_O_View t)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Telefon_O noviBr = s.Get<Telefon_O>(t.ID);

                noviBr.Telefon = t.Telefon;

                s.SaveOrUpdate(noviBr);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
        }

        public static void DeleteTelefonO(int idTel)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Telefon_O t = s.Get<Telefon_O>(idTel);

                s.Delete(t);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
        }

        #endregion

        #region Duzi [Ekipa-Vozilo]

        public static List<Duzi_View> ReadSveEkipaDuziVozilo()
        {
            ISession s = DataLayer.GetSession();
            
            List<Duzi> d = s.Query<Duzi>().ToList();
            List<Duzi_View> dPregled = d.Select(pr => new Duzi_View(pr)).ToList();

            s.Close();
            return dPregled;
        }

        public static List<Duzi_View> ReadZaduzenjeEkipe(int idEkipe)
        {
            List<Duzi_View> duzi = new List<Duzi_View>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Duzi> du = from q in s.Query<Duzi>()
                                       where q.Ekipa.ID == idEkipe
                                       select q;

                foreach(Duzi d in du)
                {
                    duzi.Add(new Duzi_View(d));
                }

                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
            return duzi;
        }

        public static void CreateEkipaDuziVozilo(int idEkipe, int idVozila, int vreme)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Duzi duzi = new Duzi();

                Ekipa e = s.Get<Ekipa>(idEkipe);
                duzi.Ekipa = e;

                Vozilo v = s.Get<Vozilo>(idVozila);
                duzi.Vozilo = v;

                duzi.Duzi_Od = DateTime.Now;
                duzi.Duzi_Do = DateTime.Now.AddDays(vreme);

                s.Save(duzi);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
        }

        public static void UpdateEkipaDuziVozilo(Duzi_View d)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Duzi duzi = s.Get<Duzi>(d.ID);

                Ekipa e = s.Get<Ekipa>(d.Ekipa);
                duzi.Ekipa = e;

                Vozilo v = s.Get<Vozilo>(d.Vozilo);
                duzi.Vozilo = v;

                duzi.Duzi_Od = d.Duzi_Od;
                duzi.Duzi_Do = d.Duzi_Do;

                s.SaveOrUpdate(duzi);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
        }

        public static void DeleteEkipaDuziVozilo(int idDuzi)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Duzi d = s.Get<Duzi>(idDuzi);

                s.Delete(d);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
        }

        #endregion

        #region Intervencija [Ekipa-Objekat]

        public static List<Intervencija_View> ReadSveIntervencije()
        {
            ISession s = DataLayer.GetSession();

            List<Intervencija> inter = s.Query<Intervencija>()
                                        .ToList();
            List<Intervencija_View> interPregled = inter.Select(pr => new Intervencija_View(pr)).ToList();

            s.Close();
            return interPregled;
        }

        public static List<Intervencija_View> ReadIntervencijeEkipe(int idEkipe)
        {
            List<Intervencija_View> intervencija = new List<Intervencija_View>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Intervencija> inter = from q in s.Query<Intervencija>()
                                                  where q.Ekipa.ID == idEkipe
                                                  select q;

                foreach (Intervencija i in inter)
                {
                    intervencija.Add(new Intervencija_View(i));
                }

                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
            return intervencija;
        }

        public static void CreateIntervencija(Intervencija_View inter, int idEk, int idOb)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Ekipa e = s.Get<Ekipa>(idEk);
                Objekat o = s.Get<Objekat>(idOb);

                Intervencija intervencija = new Intervencija()
                {
                    Ekipa = e,
                    Objekat = o,
                    Datum = inter.Datum,
                    Vreme = inter.Vreme,
                    Opis = inter.Opis
                };

                s.Save(intervencija);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
        }

        public static void UpdateIntervencija(Intervencija_View i)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Intervencija inter = s.Get<Intervencija>(i.ID);

                Ekipa e = s.Get<Ekipa>(i.Ekipa.ID);
                inter.Ekipa = e;

                Objekat o = s.Get<Objekat>(i.Objekat.ID);
                inter.Objekat = o;

                inter.Datum = i.Datum;
                inter.Vreme = i.Vreme;
                inter.Opis = i.Opis;

                s.SaveOrUpdate(inter);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
        }

        public static void DeleteIntervencija(int idInter)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Intervencija i = s.Get<Intervencija>(idInter);

                s.Delete(i);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
        }

        #endregion

        #region Odrzava [TehnickoLice-AlarmniSistem]

        public static List<Odrzava_View> ReadSvaOdrzavanja()
        {
            ISession s = DataLayer.GetSession();

            List<Odrzava> odrz = s.Query<Odrzava>()
                                   .ToList();
            List<Odrzava_View> odrzPregled = odrz.Select(pr => new Odrzava_View(pr)).ToList();

            s.Close();
            return odrzPregled;
        }

        public static List<Odrzava_View> ReadOdrzavanjeTehLica(int idTehLica)
        {
            List<Odrzava_View> odrzavanja = new List<Odrzava_View>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Odrzava> odrz = from q in s.Query<Odrzava>()
                                                  where q.Tehnicko_Lice.ID == idTehLica
                                                  select q;

                foreach (Odrzava o in odrz)
                {
                    odrzavanja.Add(new Odrzava_View(o));
                }

                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
            return odrzavanja;
        }

        public static void CreateOdrzava(Odrzava_View odrzavanje, int idAS, int idTL)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Tehnicko_Lice tl = s.Get<Tehnicko_Lice>(idTL);
                Alarmni_Sistem sis = s.Get<Alarmni_Sistem>(idAS);

                Odrzava odrz = new Odrzava()
                {
                    Tehnicko_Lice = tl,
                    Alarmni_Sistem = sis,
                    Datum_Od = odrzavanje.Datum_Od,
                    Datum_Do = odrzavanje.Datum_Do
                };

                s.Save(odrz);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
        }

        public static void UpdateOdrzava(Odrzava_View odrz)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Odrzava od = s.Get<Odrzava>(odrz.ID);

                od.Datum_Od = odrz.Datum_Od;
                od.Datum_Do = odrz.Datum_Do;

                s.SaveOrUpdate(od);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
        }

        public static void DeleteOdrzava(int idOdrzavanja)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Odrzava o = s.Get<Odrzava>(idOdrzavanja);

                s.Delete(o);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
        }

        #endregion

        #region Zaduzena [Ekipa-Objekat]

        public static List<Zaduzena_View> ReadSvaZaduzenja()
        {
            ISession s = DataLayer.GetSession();

            List<Zaduzena> zaduz = s.Query<Zaduzena>()
                                    .ToList();
            List<Zaduzena_View> zaduzPregled = zaduz.Select(pr => new Zaduzena_View(pr)).ToList();

            s.Close();
            return zaduzPregled;
        }

        public static List<Zaduzena_View> ReadZaduzenjaEkipe(int idEkipe)
        {
            List<Zaduzena_View> zaduzenja = new List<Zaduzena_View>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Zaduzena> zaduz = from q in s.Query<Zaduzena>()
                                              where q.Ekipa.ID == idEkipe
                                              select q;

                foreach (Zaduzena z in zaduz)
                {
                    zaduzenja.Add(new Zaduzena_View(z));
                }

                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
            return zaduzenja;
        }

        public static void CreateZaduzena(int idEk, int idObj)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Ekipa e = s.Get<Ekipa>(idEk);
                Objekat o = s.Get<Objekat>(idObj);

                Zaduzena zaduz = new Zaduzena()
                {
                    Ekipa = e,
                    Objekat = o,
                };

                s.Save(zaduz);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
        }

        public static void UpdateZaduzena(Zaduzena_View zaduz, int idEk)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zaduzena z = s.Get<Zaduzena>(zaduz.ID);
                Ekipa e = s.Get<Ekipa>(idEk);

                z.Ekipa = e;

                s.SaveOrUpdate(z);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
        }

        public static void DeleteZaduzena(int idZad)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zaduzena z = s.Get<Zaduzena>(idZad);

                s.Delete(z);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
        }

        #endregion

        #region Radi [Ekipa-Smena]

        public static List<Radi_View> ReadSvaRadi()
        {
            ISession s = DataLayer.GetSession();

            List<Radi> radi = s.Query<Radi>()
                                .ToList();
            List<Radi_View> radiPregled = radi.Select(pr => new Radi_View(pr)).ToList();

            s.Close();
            return radiPregled;
        }

        public static List<Radi_View> ReadRadiJedneEkipe(int idE)
        {
            List<Radi_View> radi = new List<Radi_View>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Radi> rd = from q in s.Query<Radi>()
                                       where q.Ekipa.ID == idE
                                       select q;

                foreach (Radi r in rd)
                {
                    radi.Add(new Radi_View(r));
                }

                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
            return radi;
        }

        public static void CreateRadi(int idEk, int idSm)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Ekipa e = s.Get<Ekipa>(idEk);
                Smena sm = s.Get<Smena>(idSm);

                Radi rd = new Radi()
                {
                    Ekipa = e,
                    Smena = sm
                };

                s.Save(rd);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
        }

        public static void UpdateRadi(Radi_View rd, int idEk)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Radi r = s.Get<Radi>(rd.ID);
                Ekipa e = s.Get<Ekipa>(idEk);

                r.Ekipa = e;

                s.SaveOrUpdate(r);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
        }

        public static void DeleteRadi(int idRadi)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Radi r = s.Get<Radi>(idRadi);

                s.Delete(r);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
        }

        #endregion

        #region Obilazi [Objekat-Smena]

        public static List<Obilazi_View> ReadSvaObilazenja()
        {
            ISession s = DataLayer.GetSession();

            List<Obilazi> ob = s.Query<Obilazi>()
                                 .ToList();
            List<Obilazi_View> obPregled = ob.Select(pr => new Obilazi_View(pr)).ToList();

            s.Close();
            return obPregled;
        }

        public static List<Obilazi_View> ReadObilazenjaObjekta(int idObj)
        {
            List<Obilazi_View> obilazenja = new List<Obilazi_View>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Obilazi> ob = from q in s.Query<Obilazi>()
                                          where q.Objekat.ID ==idObj
                                          select q;

                foreach (Obilazi o in ob)
                {
                    obilazenja.Add(new Obilazi_View(o));
                }

                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
            return obilazenja;
        }

        public static void CreateObilazi(int idOb, int idSm)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Smena sm = s.Get<Smena>(idSm);
                Objekat ob = s.Get<Objekat>(idOb);

                Obilazi obil = new Obilazi()
                {
                    Smena = sm,
                    Objekat = ob
                };

                s.Save(obil);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
        }

        public static void UpdateObilazi(Obilazi_View ob, int idSm)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Obilazi o = s.Get<Obilazi>(ob.ID);
                Smena sm = s.Get<Smena>(idSm);

                o.Smena = sm;

                s.SaveOrUpdate(o);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
        }

        public static void DeleteObilazi(int idOb)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Obilazi o = s.Get<Obilazi>(idOb);

                s.Delete(o);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
        }

        #endregion
    }
}
