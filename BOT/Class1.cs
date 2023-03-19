using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BOT
{

    public class Class1
    {
        public List<string> barcelona;


        public Class1()
        {
            barcelona = new List<string> { "https://ostrovok.ru/hotel/spain/barcelona/mid7486915/lyon/?q=513&dates=11.03.2023-12.03.2023&guests=2&price=one&room=s-9824088d-fa1e-5890-9570-07de4aeba22e&serp_price=lyon.10920.RUB.h-8c30bf39-d8f1-5dd9-85a1-37a1fa0104f1&stars=1&sid=d5797f79-538c-493d-b2cd-630c981c276d",
    "https://ostrovok.ru/hotel/spain/barcelona/mid7701537/travelodge_barcelona_poblenou/?q=513&dates=11.03.2023-12.03.2023&guests=2&price=one&room=s-a3e2e63e-cabe-5e60-8f05-bbff1e0ba44c&serp_price=travelodge_barcelona_poblenou.6866.RUB.h-57407ee6-ac74-50d4-b8aa-cccfc8e2c761&stars=1&sid=d5797f79-538c-493d-b2cd-630c981c276d",
    "https://ostrovok.ru/hotel/spain/barcelona/mid7465692/transit/?q=513&dates=11.03.2023-12.03.2023&guests=2&price=one&room=s-21128e87-1c45-52aa-9b74-88a6e878ed58&serp_price=transit.11631.RUB.h-6db5cbfd-dbce-5e89-9f43-7b823b9b3719&stars=1&sid=d5797f79-538c-493d-b2cd-630c981c276d",
    "https://ostrovok.ru/hotel/spain/l'hospitalet_de_llobregat/mid8991181/easyhotel_barcelona_fira/?q=513&dates=11.03.2023-12.03.2023&guests=2&price=one&room=s-7abe9360-bc48-5780-81f9-d71f98d43714&serp_price=easyhotel_barcelona_fira.6931.RUB.h-198990b7-8bcf-5002-b714-d7b9d1844b7d&stars=1&sid=d5797f79-538c-493d-b2cd-630c981c276d" };
        }

        public string SelectRandomHotel(List<string> hotels)
        {
            Random random = new Random();
            int index = random.Next(this.barcelona.Count);
            return this.barcelona[index];
        }
    }
    public class Class2
    {
        public List<string> barcelona2;


        public Class2()
        {
            barcelona2 = new List<string> { "https://ostrovok.ru/hotel/spain/barcelona/mid7482391/constanza_hotel/?q=513&dates=11.03.2023-12.03.2023&guests=2&price=one&room=s-c4ccf951-3243-58db-a9eb-d56b3bb96eef&serp_price=constanza_hotel.11812.RUB.h-5d4be20f-dd5e-58a6-b39f-3b3e8c2bbe56&stars=2&sid=479dffb1-626c-42fb-9b2f-279ab78f856b",
    "https://ostrovok.ru/hotel/spain/barcelona/mid7482919/via_augusta_hotel/?q=513&dates=11.03.2023-12.03.2023&guests=2&price=one&room=s-6f7c62fb-1f0e-5716-a0cc-675b069bb926&serp_price=via_augusta_hotel.13538.RUB.h-5f196210-38cf-5913-a209-c4d39c0bc038&stars=2&sid=479dffb1-626c-42fb-9b2f-279ab78f856b",
    "https://ostrovok.ru/hotel/spain/barcelona/mid7486912/santa_marta/?q=513&dates=11.03.2023-12.03.2023&guests=2&price=one&room=s-d95434b7-d44b-5590-a67a-770682e92201&serp_price=santa_marta.14692.RUB.h-960319ff-ea3e-554f-ac0e-004bd9f4c3f1&stars=2&sid=479dffb1-626c-42fb-9b2f-279ab78f856b"
     };
        }

        public string SelectRandomHotel(List<string> hotels)
        {
            Random random2 = new Random();
            int index = random2.Next(this.barcelona2.Count);
            return this.barcelona2[index];
        }
    }

    public class Class3
    {
        public List<string> barcelona3;


        public Class3()
        {
            barcelona3 = new List<string> { "https://ostrovok.ru/hotel/spain/barcelona/mid7481469/hotel_glories/?q=513&dates=11.03.2023-12.03.2023&guests=2&price=one&stars=3&sid=185ed4bf-4b22-4bd2-b6cd-2e17b1a2a02f",
    "https://ostrovok.ru/hotel/spain/barcelona/mid7486913/rialto/?q=513&dates=11.03.2023-12.03.2023&guests=2&price=one&room=s-ec79ce5c-70e9-5ef8-b7c5-05799845a7f0&serp_price=rialto.17511.RUB.h-2e487322-45da-59d2-bbf5-05eb91f434e1&stars=3&sid=185ed4bf-4b22-4bd2-b6cd-2e17b1a2a02f",
    "https://ostrovok.ru/hotel/spain/barcelona/mid7486576/catalonia_hotel_avinyo/?q=513&dates=11.03.2023-12.03.2023&guests=2&price=one&room=s-7e8c72fb-713b-572c-9dfb-d91ca2d0d86f&serp_price=catalonia_hotel_avinyo.14834.RUB.h-3d4fe4cb-9f72-5839-865b-ab5e504da6bd&stars=3&sid=185ed4bf-4b22-4bd2-b6cd-2e17b1a2a02f"
     };
        }

        public string SelectRandomHotel(List<string> hotels)
        {
            Random random3 = new Random();
            int index = random3.Next(this.barcelona3.Count);
            return this.barcelona3[index];
        }

    }

    public class Class4
    {
        public List<string> barcelona4;


        public Class4()
        {
            barcelona4 = new List<string> { "https://ostrovok.ru/hotel/spain/barcelona/mid6772059/two_hotel_barcelona_by_axel/?q=513&dates=11.03.2023-12.03.2023&guests=2&price=one&room=s-453f50e0-4078-5036-9182-0f7f2f0e3f5b&serp_price=two_hotel_barcelona_by_axel.13355.RUB.h-1b91b67c-fe70-548c-84c6-8538bfe68efd&stars=4&sid=b69f213d-d1de-4547-ac39-8f730373ba54",
    "https://ostrovok.ru/hotel/spain/barcelona/mid7450575/hotel_4_barcelona/?q=513&dates=11.03.2023-12.03.2023&guests=2&price=one&room=s-3df58aae-a7a2-57bd-9d39-74c053d80e65&serp_price=hotel_4_barcelona.11187.RUB.h-f696fd30-c80d-5659-98e8-18644ec61821&stars=4&sid=b69f213d-d1de-4547-ac39-8f730373ba54",
    "https://ostrovok.ru/hotel/spain/barcelona/mid8064736/h10_urquinaona_plaza/?q=513&dates=11.03.2023-12.03.2023&guests=2&price=one&room=s-e158894a-f87e-5f3d-9bbe-a66b040cb603&serp_price=h10_urquinaona_plaza.18343.RUB.h-3d043cca-ffd1-59d1-a683-6f905e6e5a5b&stars=4&sid=b69f213d-d1de-4547-ac39-8f730373ba54"
     };
        }

        public string SelectRandomHotel(List<string> hotels)
        {
            Random random4 = new Random();
            int index = random4.Next(this.barcelona4.Count);
            return this.barcelona4[index];
        }
    }

    public class Class5
    {
        public List<string> barcelona5;


        public Class5()
        {
            barcelona5 = new List<string> { "https://ostrovok.ru/hotel/spain/barcelona/mid6772059/two_hotel_barcelona_by_axel/?q=513&dates=11.03.2023-12.03.2023&guests=2&price=one&room=s-453f50e0-4078-5036-9182-0f7f2f0e3f5b&serp_price=two_hotel_barcelona_by_axel.13355.RUB.h-1b91b67c-fe70-548c-84c6-8538bfe68efd&stars=4&sid=b69f213d-d1de-4547-ac39-8f730373ba54",
    "https://ostrovok.ru/hotel/spain/barcelona/mid7450575/hotel_4_barcelona/?q=513&dates=11.03.2023-12.03.2023&guests=2&price=one&room=s-3df58aae-a7a2-57bd-9d39-74c053d80e65&serp_price=hotel_4_barcelona.11187.RUB.h-f696fd30-c80d-5659-98e8-18644ec61821&stars=4&sid=b69f213d-d1de-4547-ac39-8f730373ba54",
    "https://ostrovok.ru/hotel/spain/barcelona/mid8064736/h10_urquinaona_plaza/?q=513&dates=11.03.2023-12.03.2023&guests=2&price=one&room=s-e158894a-f87e-5f3d-9bbe-a66b040cb603&serp_price=h10_urquinaona_plaza.18343.RUB.h-3d043cca-ffd1-59d1-a683-6f905e6e5a5b&stars=4&sid=b69f213d-d1de-4547-ac39-8f730373ba54"
     };
        }

        public string SelectRandomHotel(List<string> hotels)
        {
            Random random5 = new Random();
            int index = random5.Next(this.barcelona5.Count);
            return this.barcelona5[index];
        }
    }

    public class Madr1
    {
        public List<string> madrid1;


        public Madr1()
        {
            madrid1 = new List<string> { "https://ostrovok.ru/hotel/spain/madrid/mid7608054/travelodge_madrid_alcala_2/?q=2198&dates=11.03.2023-12.03.2023&guests=2&price=one&room=s-b33a827f-9a94-5dde-a4d9-17a7df0013cc&serp_price=travelodge_madrid_alcala_2.6859.RUB.h-f2711ed4-2112-5325-8f9a-d7a5c64fd316&stars=1&sid=1e54183f-df19-4128-a29a-945ad729ce91",
    "https://ostrovok.ru/hotel/spain/madrid/mid7826246/ibis_madrid_valentin_beato/?q=2198&dates=11.03.2023-12.03.2023&guests=2&price=one&room=s-f766eef2-62e6-5084-ab1e-1bb19bddc4b0&serp_price=ibis_madrid_valentin_beato.10140.RUB.h-1bde4c49-b311-5b26-ad67-97ffe89386db&stars=1&sid=1e54183f-df19-4128-a29a-945ad729ce91",
    "https://ostrovok.ru/hotel/spain/madrid/mid7814117/hostal_la_estrella/?q=2198&dates=11.03.2023-12.03.2023&guests=2&price=one&room=s-ff6829ff-046a-58c1-91a3-e7a70e01b8f9&serp_price=hostal_la_estrella.9723.RUB.h-befb83c1-ff08-52d0-80fa-222b1f7fea9c&stars=1&sid=1e54183f-df19-4128-a29a-945ad729ce91"
     };
        }

        public string SelectRandomHotel(List<string> hotels)
        {
            Random random_madr1 = new Random();
            int index = random_madr1.Next(this.madrid1.Count);
            return this.madrid1[index];
        }
    }
    public class Madr2
    {
        public List<string> madrid2;


        public Madr2()
        {
            madrid2 = new List<string> { "https://ostrovok.ru/hotel/spain/madrid/mid7485354/hotel_santander/?q=2198&dates=11.03.2023-12.03.2023&guests=2&price=one&room=s-9f1ab9c6-8dba-5606-9f14-46794ddfbbcf&serp_price=hotel_santander.16732.RUB.h-6694a1df-038a-57c7-9033-5eb8176058db&stars=2&sid=07381417-dc1e-4b7a-8c74-5a402459e272",
    "https://ostrovok.ru/hotel/spain/madrid/mid7483386/room_mate_mario/?q=2198&dates=11.03.2023-12.03.2023&guests=2&price=one&room=s-57c797f7-4284-51fe-a7e8-f933319f5414&serp_price=room_mate_mario.19007.RUB.h-c87f6aad-53af-59d0-a479-1935ca1d5634&stars=2&sid=07381417-dc1e-4b7a-8c74-5a402459e272",
    "https://ostrovok.ru/hotel/spain/madrid/mid7482579/hotel_neomagna/?q=2198&dates=11.03.2023-12.03.2023&guests=2&price=one&room=s-75641fbd-f9d4-5e78-989f-c9184652a3a1&serp_price=hotel_neomagna.15908.RUB.h-859d09a3-2acc-5575-83dd-54c00e9b3532&stars=2&sid=07381417-dc1e-4b7a-8c74-5a402459e272"
     };
        }

        public string SelectRandomHotel(List<string> hotels)
        {
            Random random_madr2 = new Random();
            int index = random_madr2.Next(this.madrid2.Count);
            return this.madrid2[index];
        }
    }

    public class Madr3
    {
        public List<string> madrid3;


        public Madr3()
        {
            madrid3 = new List<string> { "https://ostrovok.ru/hotel/spain/madrid/mid7481284/travelodge_madrid_torrelaguna/?q=2198&dates=11.03.2023-12.03.2023&guests=2&price=one&room=s-3897bc3f-5eff-5d41-b574-2183b73dfc1f&serp_price=travelodge_madrid_torrelaguna.10639.RUB.h-edcd2b94-071f-5490-ba76-8855ab0b964b&stars=3&sid=f54d0b7d-33e6-4db9-9ccd-bd3c2beea0c2",
    "https://ostrovok.ru/hotel/spain/madrid/mid7482392/petit_palace_avenida_gran_via/?q=2198&dates=11.03.2023-12.03.2023&guests=2&price=one&room=s-9be3d4f6-5458-500d-adec-a278c20ef00f&serp_price=petit_palace_avenida_gran_via.18926.RUB.h-71761fd4-a85c-5759-ac26-1480e8de028e&stars=3&sid=f54d0b7d-33e6-4db9-9ccd-bd3c2beea0c2",
    "https://ostrovok.ru/hotel/spain/madrid/mid7481752/hotel_puerta_de_toledo/?q=2198&dates=11.03.2023-12.03.2023&guests=2&price=one&room=s-1503843a-8b68-54a6-b790-fca2f41b2990&serp_price=hotel_puerta_de_toledo.17924.RUB.h-8fce5a6a-98e3-581e-908e-cd3b91bd7802&stars=3&sid=f54d0b7d-33e6-4db9-9ccd-bd3c2beea0c2"
     };
        }

        public string SelectRandomHotel(List<string> hotels)
        {
            Random random_madr3 = new Random();
            int index = random_madr3.Next(this.madrid3.Count);
            return this.madrid3[index];
        }
    }

    public class Madr4
    {
        public List<string> madrid4;


        public Madr4()
        {
            madrid4 = new List<string> { "https://ostrovok.ru/hotel/spain/madrid/mid7486869/suite_prado_hotel/?q=2198&dates=11.03.2023-12.03.2023&guests=2&price=one&room=s-d6cb734e-b92a-5471-92d9-7f58977379a3&serp_price=suite_prado_hotel.24703.RUB.h-8958ff61-99aa-53d2-8580-f34b4ea9067a&stars=4&sid=bbdada90-8763-4b04-9ac3-bfeb5d24abb4",
    "https://ostrovok.ru/hotel/spain/madrid/mid7479684/husa_paseo_del_arte/?q=2198&dates=11.03.2023-12.03.2023&guests=2&price=one&room=s-732759d0-3dda-5596-a734-a678ada2a969&serp_price=husa_paseo_del_arte.23640.RUB.h-3a151127-9f2d-5fc8-8882-609b39f40d16&stars=4&sid=bbdada90-8763-4b04-9ac3-bfeb5d24abb4",
    "https://ostrovok.ru/hotel/spain/madrid/mid7481763/hotel_gran_versalles/?q=2198&dates=11.03.2023-12.03.2023&guests=2&price=one&room=s-a1650371-ef6e-5bbf-b690-bf5cb9a50f46&serp_price=hotel_gran_versalles.75628.RUB.h-d2f90425-7ae8-5667-b1df-f9549f55c7da&stars=4&sid=bbdada90-8763-4b04-9ac3-bfeb5d24abb4"
     };
        }

        public string SelectRandomHotel(List<string> hotels)
        {
            Random random_madr4 = new Random();
            int index = random_madr4.Next(this.madrid4.Count);
            return this.madrid4[index];
        }
    }

    public class Madr5
    {
        public List<string> madrid5;


        public Madr5()
        {
            madrid5 = new List<string> { "https://ostrovok.ru/hotel/spain/madrid/mid7475943/villa_real_hotel/?q=2198&dates=11.03.2023-12.03.2023&guests=2&price=one&room=s-9a4e81a3-6b3f-5be2-8653-9163a4012c9a&serp_price=villa_real_hotel.20862.RUB.h-156110aa-ea5d-5421-bbd9-a40a7b5d8cec&stars=5&sid=886caa68-25e6-475c-a87f-e804da220b4f",
    "https://ostrovok.ru/hotel/spain/madrid/mid7482569/urban/?q=2198&dates=11.03.2023-12.03.2023&guests=2&price=one&room=s-4bbeebda-9b90-5ec4-86ab-a8a1fa71c148&serp_price=urban.20555.RUB.h-16507479-2c04-5cb1-a526-7eff60b09fb5&stars=5&sid=886caa68-25e6-475c-a87f-e804da220b4f",
    "https://ostrovok.ru/hotel/spain/madrid/mid8732462/puerta_america_hotel/?q=2198&dates=11.03.2023-12.03.2023&guests=2&price=one&room=s-2251719a-0ca5-573f-a4ad-9dd2ce3b1759&serp_price=puerta_america_hotel.16800.RUB.h-91352a4c-813c-50ff-a33b-40d73997863b&stars=5&sid=886caa68-25e6-475c-a87f-e804da220b4f"
     };
        }

        public string SelectRandomHotel(List<string> hotels)
        {
            Random random_madr5 = new Random();
            int index = random_madr5.Next(this.madrid5.Count);
            return this.madrid5[index];
        }
    }

    public class PSG1
    {
        public List<string> psg1;


        public PSG1()
        {
            psg1 = new List<string> { "https://ostrovok.ru/hotel/france/paris/mid7577322/hotel_jarry_confort/?q=2734&guests=2&price=one&stars=1&sid=0462e55b-cdcc-4fb1-bd12-be5ba01d27f8",
    "https://ostrovok.ru/hotel/france/paris/mid7858609/sully_hotel/?q=2734&guests=2&price=one&stars=1&sid=0462e55b-cdcc-4fb1-bd12-be5ba01d27f8",
    "https://ostrovok.ru/hotel/france/montreuil/mid7575780/premiere_classe_montreuil/?q=2734&guests=2&price=one&stars=1&sid=0462e55b-cdcc-4fb1-bd12-be5ba01d27f8"
     };
        }

        public string SelectRandomHotel(List<string> hotels)
        {
            Random random_psg1 = new Random();
            int index = random_psg1.Next(this.psg1.Count);
            return this.psg1[index];
        }
    }

    public class PSG2
    {
        public List<string> psg2;


        public PSG2()
        {
            psg2 = new List<string> { "https://ostrovok.ru/hotel/france/charenton-le-pont/mid7577513/adagio_access_paris_porte_de_charenton_2/?q=2734&guests=2&price=one&stars=2&sid=fe39452c-686b-4ecc-abf5-7b55fb153043",
    "https://ostrovok.ru/hotel/france/paris/mid7829970/victoria_4/?q=2734&guests=2&price=one&stars=2&sid=fe39452c-686b-4ecc-abf5-7b55fb153043",
    "https://ostrovok.ru/hotel/france/paris/mid7714978/transcontinental/?q=2734&guests=2&price=one&stars=2&sid=fe39452c-686b-4ecc-abf5-7b55fb153043"
     };
        }

        public string SelectRandomHotel(List<string> hotels)
        {
            Random random_psg2 = new Random();
            int index = random_psg2.Next(this.psg2.Count);
            return this.psg2[index];
        }
    }

    public class PSG3
    {
        public List<string> psg3;


        public PSG3()
        {
            psg3 = new List<string> { "https://ostrovok.ru/hotel/france/paris/mid7860057/source_hotel/?q=2734&guests=2&price=one&stars=3&sid=b46bddc9-411b-4e8b-b1e1-d417ad5616bd",
    "https://ostrovok.ru/hotel/france/ivry-sur-seine/mid7579740/adagio_access_paris_quai_divry/?q=2734&guests=2&price=one&stars=3&sid=b46bddc9-411b-4e8b-b1e1-d417ad5616bd",
    "https://ostrovok.ru/hotel/france/villejuif/mid7495946/park__suites_elegance_villejuif/?q=2734&dates=11.03.2023-12.03.2023&guests=2&price=one&room=s-2ec366ef-775b-51cf-9ea0-749202bae1be&serp_price=park__suites_elegance_villejuif.6834.RUB.h-16a7aafb-8010-522b-9867-310dadd3e192&stars=3&sid=b46bddc9-411b-4e8b-b1e1-d417ad5616bd"
     };
        }

        public string SelectRandomHotel(List<string> hotels)
        {
            Random random_psg3 = new Random();
            int index = random_psg3.Next(this.psg3.Count);
            return this.psg3[index];
        }
    }

    public class PSG4
    {
        public List<string> psg4;


        public PSG4()
        {
            psg4 = new List<string> { "https://ostrovok.ru/hotel/france/paris/mid7581219/holiday_inn_paris__bastille/?q=2734&guests=2&price=one&stars=4&sid=23f8b311-b5bb-4da2-ac96-5d116dd4a3ce",
    "https://ostrovok.ru/hotel/france/paris/mid8575027/saint_sulpice/?q=2734&guests=2&price=one&stars=4&sid=23f8b311-b5bb-4da2-ac96-5d116dd4a3ce4",
    "https://ostrovok.ru/hotel/france/paris/mid7572390/hotel_regina_opera/?q=2734&guests=2&price=one&stars=4&sid=23f8b311-b5bb-4da2-ac96-5d116dd4a3ce"
     };
        }

        public string SelectRandomHotel(List<string> hotels)
        {
            Random random_psg4 = new Random();
            int index = random_psg4.Next(this.psg4.Count);
            return this.psg4[index];
        }
    }

    public class PSG5
    {
        public List<string> psg5;


        public PSG5()
        {
            psg5 = new List<string> { "https://ostrovok.ru/hotel/france/paris/mid7596435/intercontinental_paris_le_grand/?q=2734&dates=11.03.2023-12.03.2023&guests=2&price=one&room=s-9155632d-9605-50f6-a95d-b10c32127956&serp_price=intercontinental_paris_le_grand.48745.RUB.h-79f2e65c-620e-551c-8b29-ed1127defa1c&stars=5&sid=3238a66a-b3c2-47d2-9758-b5dc975cea55",
    "https://ostrovok.ru/hotel/france/paris/mid8743136/hotel_parister/?q=2734&dates=11.03.2023-12.03.2023&guests=2&price=one&room=s-6df2d4a8-2a84-5fd2-915b-465ae4b9894c&serp_price=hotel_parister.29570.RUB.h-11182fde-443b-5f37-a850-8a31e955a490&stars=5&sid=3238a66a-b3c2-47d2-9758-b5dc975cea55",
    "https://ostrovok.ru/hotel/france/paris/mid7576706/hotel_baltimore_paris__mgallery_collection/?q=2734&dates=11.03.2023-12.03.2023&guests=2&price=one&room=s-371b4384-b0f5-5c56-8733-75692c05fd3a&serp_price=hotel_baltimore_paris__mgallery_collection.35926.RUB.h-30c0afd6-9926-5c42-92df-0ec1e61238d3&stars=5&sid=3238a66a-b3c2-47d2-9758-b5dc975cea55"
     };
        }

        public string SelectRandomHotel(List<string> hotels)
        {
            Random random_psg5 = new Random();
            int index = random_psg5.Next(this.psg5.Count);
            return this.psg5[index];
        }
    }

    public class TUL1
    {
        public List<string> tul1;


        public TUL1()
        {
            tul1 = new List<string> { "https://ostrovok.ru/hotel/france/blagnac/mid7570169/premiere_classe_toulouse_ouest__blagnac_aeroport/?q=6034506&dates=11.03.2023-12.03.2023&guests=2&price=one&room=s-877dd208-21aa-585b-8a34-cb18dfeb4264&serp_price=premiere_classe_toulouse_ouest__blagnac_aeroport.4958.RUB.h-9f2301bb-7de2-5893-b58e-df9f64fa0a0d&stars=1&sid=184d88fb-b313-4f67-ab5b-3c5d1b450f8e",
    "https://ostrovok.ru/hotel/france/toulouse/mid7571358/premiere_classe_toulouse_sesquieres/?q=6034506&dates=11.03.2023-12.03.2023&guests=2&price=one&room=s-b28628c8-8cd6-59ea-8e41-dfd40bf5cb11&serp_price=premiere_classe_toulouse_sesquieres.4855.RUB.h-6ec899ea-7a59-5e80-a8f9-f671e72959d3&stars=1&sid=184d88fb-b313-4f67-ab5b-3c5d1b450f8e"
    
     };
        }

        public string SelectRandomHotel(List<string> hotels)
        {
            Random random_tul1 = new Random();
            int index = random_tul1.Next(this.tul1.Count);
            return this.tul1[index];
        }
    }

    public class TUL2
    {
        public List<string> tul2;


        public TUL2()
        {
            tul2 = new List<string> { "https://ostrovok.ru/hotel/france/toulouse/mid7577070/adagio_access_toulouse_jolimont/?q=6034506&dates=11.03.2023-12.03.2023&guests=2&price=one&room=s-4bc0c046-8512-5f0f-926e-396ea9052c17&serp_price=adagio_access_toulouse_jolimont.4453.RUB.h-11fd5341-3504-5adf-b725-5a6aedaa988b&stars=2&sid=96a6ff92-faf6-4f3b-aa5f-912fec9aee26",
    "https://ostrovok.ru/hotel/france/toulouse/mid7463465/hotel_de_bordeaux_5/?q=6034506&dates=11.03.2023-12.03.2023&guests=2&price=one&room=s-6877fe7b-6c4a-5fe1-a442-870985d43874&serp_price=hotel_de_bordeaux_5.6990.RUB.h-ef02b91c-c363-522b-b250-eba120fb31af&stars=2&sid=96a6ff92-faf6-4f3b-aa5f-912fec9aee26",
    "https://ostrovok.ru/hotel/france/toulouse/mid7544909/hotel_victor_hugo_3/?q=6034506&dates=11.03.2023-12.03.2023&guests=2&price=one&room=s-b62f5292-c9c5-58cf-9ecd-f407f16ef324&serp_price=hotel_victor_hugo_3.7628.RUB.h-26ff6e16-7cd1-5e11-b73b-9b77d11ea58b&stars=2&sid=96a6ff92-faf6-4f3b-aa5f-912fec9aee26"
     };
        }

        public string SelectRandomHotel(List<string> hotels)
        {
            Random random_tul2 = new Random();
            int index = random_tul2.Next(this.tul2.Count);
            return this.tul2[index];
        }
    }

    public class TUL3
    {
        public List<string> tul3;


        public TUL3()
        {
            tul3 = new List<string> { "https://ostrovok.ru/hotel/france/toulouse/mid7441360/adagio_access_toulouse_st_cyprien/?q=6034506&dates=11.03.2023-12.03.2023&guests=2&price=one&room=s-a13180cf-559c-53a7-8cd2-401e9304cfac&serp_price=adagio_access_toulouse_st_cyprien.5174.RUB.h-83f7f003-7460-5d77-830e-7f821f8cf6b6&stars=3&sid=0078ae00-75e6-4227-ae8c-8c65726e8711",
    "https://ostrovok.ru/hotel/france/toulouse/mid8328769/residence_suite_home/?q=6034506&dates=11.03.2023-12.03.2023&guests=2&price=one&room=s-d2ab59c1-f1e4-5967-ad1a-bd99e7b4cb7a&serp_price=residence_suite_home.5355.RUB.h-6920adb7-7726-54c6-984d-526a4887e4e1&stars=3&sid=0078ae00-75e6-4227-ae8c-8c65726e8711",
    "https://ostrovok.ru/hotel/france/toulouse/mid7665018/hotel_kyriad_toulouse_centre/?q=6034506&dates=11.03.2023-12.03.2023&guests=2&price=one&room=s-cd78e338-307a-5e47-bd2e-2173e752cde2&serp_price=hotel_kyriad_toulouse_centre.5727.RUB.h-d759e555-9118-525a-a652-2c164dac4e89&stars=3&sid=0078ae00-75e6-4227-ae8c-8c65726e8711"
     };
        }

        public string SelectRandomHotel(List<string> hotels)
        {
            Random random_tul3 = new Random();
            int index = random_tul3.Next(this.tul3.Count);
            return this.tul3[index];
        }
    }

    public class TUL4
    {
        public List<string> tul4;


        public TUL4()
        {
            tul4 = new List<string> { "https://ostrovok.ru/hotel/france/blagnac/mid7502599/park__suites_prestige_toulouse_aeroport/?q=6034506&dates=11.03.2023-12.03.2023&guests=2&price=one&room=s-ec1a2a20-d64f-528b-9b19-c613d1c4f034&serp_price=park__suites_prestige_toulouse_aeroport.7707.RUB.h-ce821db7-b9ea-5905-989e-33ff513366f8&stars=4&sid=4031bed0-1dc3-4ddb-aca2-dd3e7bb8af2d",
    "https://ostrovok.ru/hotel/france/toulouse/mid6305220/odalys_apparthotel_colombelie/?q=6034506&dates=11.03.2023-12.03.2023&guests=2&price=one&room=s-6be5c186-907f-53fd-afd7-cf8afcc567cc&serp_price=odalys_apparthotel_colombelie.9137.RUB.h-ad898a82-8177-5b78-9c1f-afd23874fc9d&stars=4&sid=4031bed0-1dc3-4ddb-aca2-dd3e7bb8af2d",
    "https://ostrovok.ru/hotel/france/toulouse/mid7462951/citiz_hotel/?q=6034506&dates=11.03.2023-12.03.2023&guests=2&price=one&room=s-0f1cd57b-b833-5471-b7ae-1972c6fb4b33&serp_price=citiz_hotel.7821.RUB.h-0dcd52d7-0dfc-5050-ad2c-0f715fb0b4d3&stars=4&sid=4031bed0-1dc3-4ddb-aca2-dd3e7bb8af2d"
     };
        }

        public string SelectRandomHotel(List<string> hotels)
        {
            Random random_tul4 = new Random();
            int index = random_tul4.Next(this.tul4.Count);
            return this.tul4[index];
        }
    }

    public class TUL5
    {
        public List<string> tul5;


        public TUL5()
        {
            tul5 = new List<string> { "https://ostrovok.ru/hotel/france/toulouse/mid7541869/le_grand_balcon/?q=6034506&dates=11.03.2023-12.03.2023&guests=2&price=one&room=s-dea6a642-d7b3-5d28-887b-f3b01aa9e9d5&serp_price=le_grand_balcon.12957.RUB.h-2b26068a-a1d5-59f8-a8bd-c9f3b7ef37a7&stars=5&sid=2fd78c73-e283-496b-8451-69aa2f50f492",
    "https://ostrovok.ru/hotel/france/toulouse/mid7581026/hotel_pullman_toulouse_centre/?q=6034506&dates=11.03.2023-12.03.2023&guests=2&price=one&room=s-b0af8384-33bc-538b-922a-968f3b548149&serp_price=hotel_pullman_toulouse_centre.11686.RUB.h-b232776f-95a8-50be-9674-7280027aceba&stars=5&sid=2fd78c73-e283-496b-8451-69aa2f50f492",
    "https://ostrovok.ru/hotel/france/toulouse/mid6643030/la_cour_des_consuls_hotel_and_spa_toulouse_mgallery_by_sofitel/?q=6034506&dates=11.03.2023-12.03.2023&guests=2&price=one&room=s-d192e7c6-0de6-5dc0-8a06-9b1db6148027&serp_price=la_cour_des_consuls_hotel_and_spa_toulouse_mgallery_by_sofitel.20359.RUB.h-03fd7d7c-0d58-5fc7-9e1f-32c6cc4bf42e&stars=5&sid=2fd78c73-e283-496b-8451-69aa2f50f492"
     };
        }

        public string SelectRandomHotel(List<string> hotels)
        {
            Random random_tul5 = new Random();
            int index = random_tul5.Next(this.tul5.Count);
            return this.tul5[index];
        }
    }

}



    
    

    

    


