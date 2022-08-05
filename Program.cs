class main
{
       

 static void Main()
    { /// global
        
        float fios = 0, fioq = 0, fioc = 0, fiob = 0, fioquim = 0, fiol = 0, fioe=0, fiolav = 0, fiofer = 0, fioo = 0, fioilu = 0; float fiop = 0;
        int quartores = 0, salares = 0, cozinhares = 0, banheiores = 0, quintalres = 0, limpezares = 0, escritoriores = 0, lavadeiriares = 0, ferramentasres = 0, outrosres = 0, iluminares = 0;
        int djq = 0, djs = 0, djc = 0, djb = 0, djqui = 0, djl = 0, dje = 0, djlv = 0, djfer = 0, djo = 0, djilum = 0; int djprim = 0;
        char padrao='m'; int res = 0;



     


    string tvsc, lampadasc, arsc, sonsc, vsalac, dvdsc, tvqc, lamqc, arqc, sonqc; string batcs, liqcs, encs, asps, imps, cops, les, ares, lavs, fers, secls, lavses;
    string comqc, chbc, secc, chapc, aquc, lambc, lquimc, aquaqs, churrs, lcozc; string cafecs, gelcs, fogcs, miccs, forcs, torcs, trns, enbcs, espcs, arcs;
    string corts, aspc, boms, furs, maks, sers, ferfs, telc, slids, aquqs, copfs, lss; string opcc, opcc1;


    int encres=0, aspres=0, impres=0, copres=0, leres=0, areres=0; int churrres = 0, trnres = 0, lamres = 0, watts = 0;
    int tvs1=0, arres=0, sonsres=0, tvqres=0, lamqres=0, arqres=0, sonqres=0, comqres=0, tvsres=0, lampadasres=0;
    int chbres=0, secres=0, chapres=0, aqures=0, lambres=0, lquimres=0, aquqres=0, lcozres=0;
    int vsalares=0, dvdsres=0, cafecres=0, gelcres=0, fogcres=0, miccres=0, forcres=0, torcres=0, enbcres=0, espcres=0, arcres=0, batcres=0, liqcres=0;
    int lavres=0, ferres=0, seclres=0, lavseres=0, cortres=0, bomres=0, furres=0, makres=0, serres=0, copfres=0, ferfres=0, telres=0, slidres=0;


    int ars=0, sons=0, tvq=0, lamq=0, arq=0, sonq=0, comqtvs=0, lampadas=0, tvs=0; int churr = 0, trn = 0, lam = 0;
    int chb=0, sec=0, chap=0, aqu=0, lamb=0, comq=0, lquim=0, aquq=0, lcoz=0; int enc=0, asp=0, imp=0, cop=0, le=0, are=0;
    int ars1=0, sons1=0, tvq1=0, lamq1=0, arq1=0, sonq1=0, comq1=0, lampadas1=0; int enc1=0, asp1=0, imp1=0, cop1=0, le1=0, are1=0;
    int chb1=0, sec1=0, chap1=0, aqu1=0, lamb1=0, lquim1=0, aquq1=0, lcoz1=0; int churr1 = 0, trn1 = 0, ls1 = 0;
    int vsala=0, dvds=0, cafec=0, gelc=0, fogc=0, micc=0, forc=0, torc=0, enbc=0, espc=0, arc=0, batc=0, liqc=0;
    int vsala1=0, dvds1=0, cafec1=0, gelc1=0, fogc1=0, micc1=0, forc1=0, torc1=0, enbc1=0, espc1=0, arc1=0, batc1=0, liqc1=0;
    int lav=0, fer=0, secl=0, lavse=0, cort=0, bom=0, fur=0, mak=0, ser=0, copf=0, ferf=0, tel=0, slid=0;
    int lav1=0, fer1=0, secl1=0, lavse1=0, cort1=0, bom1=0, fur1=0, mak1=0, ser1=0, copf1=0, ferf1=0, tel1=0, slid1=0;


       




        /*   


            int LCD32=120;int led40=130;int LCD40=200;int lcd42=250;int lcd46=280; 
           // int led32=100;int  led46=150; int lcd52=310;int led52=200;int led64=250;
           // int Micro_Ondas	=2000;int Ebulidor=	1000; int Ferro =1000;int Torneira=2500;
           // int Aquecedor_passagem =6000;int Aquecedor_agua=2000;int Aquecedor_Ambiente=1000;
           // int Freezer_Horizontal =500;int Freezer_Vertical=300; int Computador1=300;int EspFrutas=200;
           // int Geladeira_Simples=250;int Geladeira_Duplex=500;int Maquina_Costura=100;int Exaustor=150;
           // int Bomba_agua=	400	; int Grill=1200; int Mini_System=150;int Condicionador=1400;
           // int Chuveiro =5500; int Cortador_Grama=	1300;int Enceradeira=300;int Secador=1000;
           // int Secadora_Roupas=3500;int Torradeira=800; int pcgamer=600;int Impressora =45;
           // int tvtubo =300;int Plasma50 =380 ;int Plasma42 =320 ;int tvled=300;int Televisor=200;
           // int arcondicionado7500btu=1000;	int arco12000 =	1450;int arco18000 =2100;int Batedeira=100;	
           // int arcondicionado10000btu=1350;int arco15000 =2000;  int Cafeteira=600;int Aspirador=600;
           // int lanled =11;int lanfluorescente =23;int lustre=100;int Lavar_Louca=1500;int Slides=	200;
           // int lanincandescente =100;int lapadatubular =40;int Churrasqueira =3000;int Liquidificador=	200;
           // int Chuveiro3t= 5500; int Chuveiro4t= 6800 ;int Chuveirolx =7800;int Vetilador=	100;int Game=20;
           // int lavaroupa8kg =200 ;int lavaroupa10kg =400;int lavaroupa12kg =500;int lavaseca =1500;
           // int lavaroupa14kg =600;int lavaroupa16kg =700;int lavaroupa18kg =800;int lavaroupa20kg =1000;
           // int som31=100;int SomAmplificada =500;int AmplificadaAmvoxACA =1500;int minisom =50;int DVD =30;
           // int Fogao4Bocas=6000;int Fogao2Bocas=3000;int Forno_Pequeno=1500;int FornoGrande=4500;
         */



        string perg , pg;
        int opc, opc1;

        bool pp=true;

        i.txt( "deseja calcular a pontencia de aparelhos (s/n)" ,'r');

       perg= Console.ReadLine();

        while ((perg == "s") || (perg == "S"))
        {



            Console.WriteLine( "digite a parte da casa que deseja calcular" );


            Console.WriteLine( "1-sala" );
            Console.WriteLine( "2-quartos" );
            Console.WriteLine( "3-banheiro" );
            Console.WriteLine( "4-quintal" );
            Console.WriteLine( "5-cozinha" );
            Console.WriteLine( "6-equipamento de limpeza" );
            Console.WriteLine( "7-escritorio" );
            Console.WriteLine( "8-lavandeiria" );
            Console.WriteLine( "9-ferramentas" );
            Console.WriteLine( "10-outros" );


          opc1= int.Parse(  Console.ReadLine( ));

            

            switch (opc1)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine( "1-tv" );
                    Console.WriteLine( "2-lampada" );
                    Console.WriteLine( "3-ar condicionado" );
                    Console.WriteLine( "4-som" );
                    Console.WriteLine( "5-videogame" );
                    Console.WriteLine( "6-dvd" );




                    opc = int.Parse(Console.ReadLine());


                    switch (opc)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine( "modelo da tv " );
                            Console.WriteLine( "1-led" );
                            Console.WriteLine( "2-smart" );
                            Console.WriteLine( "3-plasma" );
                            Console.WriteLine( "4-LCD" );
                            Console.WriteLine( "5-tubo" );
                            Console.WriteLine( "6-de 50 polegadas a cima" );


                             tvsc=Console.ReadLine();

                            // try{
                            //if ((tvs == 1 )||(tvs == 2)||(tvs == 3)||(tvs == 4)||(tvs == 5)||(tvs == 6)){
                            //Console.WriteLine("opicao invalida");break;
                            //}else{Console.WriteLine("opicao invalida");break; }



                            //}catch(const char* msg){ Console.WriteLine("Erro: ",msg); }


                            if (tvsc == "1")
                            {
                                tvs = 200;
                            }
                            else if (tvsc == "2")
                            {
                                tvs = 320;
                            }
                            else if (tvsc == "3")
                            {
                                tvs = 320;
                            }
                            else if (tvsc == "4")
                            {
                                tvs = 320;
                            }
                            else if (tvsc == "5")
                            {
                                tvs = 300;
                            }
                            else if (tvsc == "6") { tvs = 400; }
                            else { Console.WriteLine( "opcao invalida" ); break; }
                            Console.WriteLine( "quantidade de tv" );
                          tvs1 =int.Parse( Console.ReadLine( ));
                            // tvsres=tvs*tvs1;

                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine( "modelo da lampada" );
                            Console.WriteLine( "1-led" );
                            Console.WriteLine( "2-encadecete amarela" );
                            Console.WriteLine( "3-fluorescente" );
                            Console.WriteLine( "4-lustre" );
                            Console.WriteLine( "5-tubular" );

                          lampadasc = Console.ReadLine( );





                            if (lampadasc == "1")
                            {
                                lampadas = 10;
                            }
                            else if (lampadasc == "2")
                            {
                                lampadas = 100;
                            }
                            else if (lampadasc == "3")
                            {
                                lampadas = 23;
                            }
                            else if (lampadasc == "4")
                            {
                                lampadas = 100;
                            }
                            else if (lampadasc == "5")
                            {
                                lampadas = 40;
                            }
                            else { Console.WriteLine( "opicao invalida" ); break; }

                            Console.WriteLine( "quantidade de lampada" );
                          lampadas1 =int.Parse( Console.ReadLine() );
                            // lampadasres=lampadas*lampadas1;
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine( "modelo do ar condicionado" );
                            Console.WriteLine( "1-7500 btu" );
                            Console.WriteLine( "2-12000 btu" );
                            Console.WriteLine( "3-18000 btu" );
                            Console.WriteLine( "4-10000 btu" );
                            Console.WriteLine( "5-15000 btu" );
                            Console.WriteLine( "6-ventilador" );
                            Console.WriteLine( "7-ventilador de teto" );

                           arsc= Console.ReadLine( );






                            if (arsc == "1")
                            {
                                ars = 1000;
                            }
                            else if (arsc == "2")
                            {
                                ars = 1450;
                            }
                            else if (arsc == "3")
                            {
                                ars = 2100;
                            }
                            else if (arsc == "4")
                            {
                                ars = 1350;
                            }
                            else if (arsc == "5")
                            {
                                ars = 2500;
                            }
                            else if (arsc == "6")
                            {
                                ars = 100;
                            }
                            else if (arsc == "7")
                            {
                                ars = 120;
                            }
                            else { Console.WriteLine( "opicaoinvalida" ); break; }

                            Console.WriteLine( "quantidade de ar condicionado" );
                           ars1 =int.Parse(Console.ReadLine());
                            // arres=ars*ars1;

                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine( "modelo do som" );
                            Console.WriteLine( "1-som mini-system" );
                            Console.WriteLine( "2-som 3em1" );
                            Console.WriteLine( "3-som pesado" );

                           sonsc= Console.ReadLine() ;


                            if (sonsc == "1")
                            {
                                sons = 100;
                            }
                            else if (sonsc == "2")
                            {
                                sons = 500;
                            }
                            else if (sonsc == "3")
                            {
                                sons = 1500;
                            }
                            else { Console.WriteLine( "opicao invalida" ); break; }

                            Console.WriteLine( "quantidade de som" );
                         sons1 =int.Parse( Console.ReadLine());
                            //sonsres=sons*sons1;    
                            break;
                        case 5:
                            Console.Clear ();
                            Console.WriteLine( "modelo do videogame" );
                            Console.WriteLine( "1-playstation" );
                            Console.WriteLine( "2-xbox" );
                            Console.WriteLine( "3-wii" );
                            Console.WriteLine( "4-nintendo" );
                           vsalac= Console.ReadLine( );


                            if (vsalac == "1")
                            {
                                vsala = 200;
                            }
                            else if (vsalac == "2")
                            {
                                vsala = 200;
                            }
                            else if (vsalac == "3")
                            {
                                vsala = 100;
                            }
                            else if (vsalac == "4")
                            {
                                vsala = 50;
                            }
                            else { Console.WriteLine( "opicaoinvalida" ); break; }

                            Console.WriteLine( "quantidade de videogame" );
                          vsala1 =int.Parse( Console.ReadLine()) ;
                            //vsalares=vsala*vsala1;
                            break;
                        case 6:

                            Console.Clear();
                            Console.WriteLine( "modelo do dvd" );
                            Console.WriteLine( "1-dvd" );
                            Console.WriteLine( "2-dvd-home theater -simples" );
                            Console.WriteLine( "3-dvd-home theater -completo" );

                          dvdsc = Console.ReadLine() ;



                            if (dvdsc == "1")
                            {
                                dvds = 100;
                            }
                            else if (dvdsc == "2")
                            {
                                dvds = 500;
                            }
                            else if (dvdsc == "3")
                            {
                                dvds = 1000;
                            }
                            else { Console.WriteLine( "opicaoinvalida" ); break; }

                            Console.WriteLine( "quantidade de dvd" );
                            dvds1=int.Parse(Console.ReadLine()) ;

                            //dvdsres=dvds*dvds1;

                            break;

                    }


                    break;

                case 2:
                    Console.Clear() ;
                    Console.WriteLine( "1-tv" );
                    Console.WriteLine( "2-lampada" );
                    Console.WriteLine( "3-ar condicionado" );
                    Console.WriteLine( "4-som" );
                    Console.WriteLine( "5-coputador" );

                    opcc=Console.ReadLine() ;

                    if (opcc == "1") { opc = 1; }
                    else if (opcc == "2") { opc = 2; }
                    else if (opcc == "3") { opc = 3; }
                    else if (opcc == "4") { opc = 4; }
                    else if (opcc == "5") { opc = 5; }
                    else { Console.WriteLine( "opicao invalida" ); break; }


                    switch (opc)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine( "modelo da tv " );
                            Console.WriteLine( "1-led" );
                            Console.WriteLine( "2-smart" );
                            Console.WriteLine( "3-plasma" );
                            Console.WriteLine( "4-LCD" );
                            Console.WriteLine( "5-tubo" );
                            Console.WriteLine( "6-de 50 polegadas a cima" );

                            tvqc=Console.ReadLine() ;


                            if (tvqc == "1")
                            {
                                tvq = 200;
                            }
                            else if (tvqc == "2")
                            {
                                tvq = 200;
                            }
                            else if (tvqc == "3")
                            {
                                tvq = 320;
                            }
                            else if (tvqc == "4")
                            {
                                tvq = 200;
                            }
                            else if (tvqc == "5")
                            {
                                tvq = 300;
                            }
                            else if (tvqc == "6")
                            {
                                tvq = 400;
                            }
                            else { Console.WriteLine( "opicao invalida" ); break; }

                            Console.WriteLine( "quantidade de tv" );
                            tvq1=int.Parse(Console.ReadLine());

                            //tvqres=tvq*tvq1;
                            break;

                        case 2:
                            Console.Clear() ;
                            Console.WriteLine( "modelo da lampada" );
                            Console.WriteLine( "1-led" );
                            Console.WriteLine( "2-encadecete amarela" );
                            Console.WriteLine( "3-fluorescente" );
                            Console.WriteLine( "4-lustre" );
                            Console.WriteLine( "5-tubular" );
                            lamqc=Console.ReadLine() ;



                            if (lamqc == "1")
                            {
                                lamq = 10;
                            }
                            else if (lamqc == "2")
                            {
                                lamq = 100;
                            }
                            else if (lamqc == "3")
                            {
                                lamq = 23;
                            }
                            else if (lamqc == "4")
                            {
                                lamq = 100;
                            }
                            else if (lamqc == "5")
                            {
                                lamq = 40;
                            }
                            else { Console.WriteLine( "opicao invalida" ); break; }

                            Console.WriteLine( "quantidade de lampada" );
                            lamq1=int.Parse(Console.ReadLine());
                            //lamqres=lamq*lamq1;
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine( "modelo do ar condicionado" );
                            Console.WriteLine( "1-7500 btu" );
                            Console.WriteLine( "2-12000 btu" );
                            Console.WriteLine( "3-18000 btu" );
                            Console.WriteLine( "4-10000 btu" );
                            Console.WriteLine( "5-15000 btu" );
                            Console.WriteLine( "6-ventilador" );

                            arqc=Console.ReadLine();



                            if (arqc == "1")
                            {
                                arq = 1000;
                            }
                            else if (arqc == "2")
                            {
                                arq = 1450;
                            }
                            else if (arqc == "3")
                            {
                                arq = 2100;
                            }
                            else if (arqc == "4")
                            {
                                arq = 1350;
                            }
                            else if (arqc == "5")
                            {
                                arq = 2000;
                            }
                            else if (arqc == "6")
                            {
                                arq = 100;
                            }
                            else { Console.WriteLine( "opicao invalida" ); break; }

                            Console.WriteLine( "quantidade de ar condicionado" );
                            arq1=int.Parse(Console.ReadLine());
                            //arqres=arq*arq1;
                            break;

                        case 4:
                            Console.Clear() ;
                            Console.WriteLine( "modelo do som" );
                            Console.WriteLine( "1-som mini-system" );
                            Console.WriteLine( "2-som 3em1" );
                            Console.WriteLine( "3-som pesado" );

                            sonqc=Console.ReadLine() ;


                            if (sonqc == "1")
                            {
                                sonq = 100;
                            }
                            else if (sonqc == "2")
                            {
                                sonq = 500;
                            }
                            else if (sonqc == "3")
                            {
                                sonq = 1500;
                            }
                            else { Console.WriteLine( "opicao invalida" ); break; }

                            Console.WriteLine( "quantidade de som" );
                            sonq1=int.Parse(Console.ReadLine());
                            //sonqres=sonq*sonq1;
                            break;
                        case 5:
                            Console.Clear();
                            Console.WriteLine( "modelo do computador" );
                            Console.WriteLine( "1-computador" );
                            Console.WriteLine( "2-pc gamer" );
                            Console.WriteLine( "3-pc escritorio" );
                            Console.WriteLine( "4-notebook" );
                            Console.WriteLine( "5-notebook gamer" );
                            Console.WriteLine( "6-escritorio" );

                            comqc=Console.ReadLine() ;


                            if (comqc == "1")
                            {
                                comq = 300;
                            }
                            else if (comqc == "2")
                            {
                                comq = 500;
                            }
                            else if (comqc == "3")
                            {
                                comq = 400;
                            }
                            else if (comqc == "4")
                            {
                                comq = 100;
                            }
                            else if (comqc == "5")
                            {
                                comq = 200;
                            }
                            else if (comqc == "6")
                            {
                                comq = 500;
                            }
                            else { Console.WriteLine( "opicao invalida" ); break; }

                            Console.WriteLine( "quantidade de computador" );
                            comq1=int.Parse(Console.ReadLine());
                            //comqres=comq*comq1;
                            break;


                    }


                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine( "1-chuveiro" );
                    Console.WriteLine( "2-secador de cabelo" );
                    Console.WriteLine( "3-chapa de cabelo" );
                    Console.WriteLine( "4-aquecedor de agua" );
                    Console.WriteLine( "5-lampada" );

                    opcc=Console.ReadLine() ;

                    if (opcc == "1") { opc = 1; }
                    else if (opcc == "2") { opc = 2; }
                    else if (opcc == "3") { opc = 3; }
                    else if (opcc == "4") { opc = 4; }
                    else if (opcc == "5") { opc = 5; }
                    else { Console.WriteLine( "opicao invalida" ); break; }


                    switch (opc)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine( "modelo do chuveiro" );
                            Console.WriteLine( "1-chuveiro 3 teperaturas" );
                            Console.WriteLine( "2-chuveiro 4 teperaturas" );
                            Console.WriteLine( "3-chuveiro luxo" );

                            chbc=Console.ReadLine() ;


                            if (chbc == "1")
                            {
                                chb = 5500;
                            }
                            else if (chbc == "2")
                            {
                                chb = 6500;
                            }
                            else if (chbc == "3")
                            {
                                chb = 7500;
                            }
                            else { Console.WriteLine( "opicao invalida" ); break; }

                            Console.WriteLine( "quantidade de chuveiro" );
                            chb1=int.Parse(Console.ReadLine());
                            //chbres=chb*chb1;
                            break;

                        case 2:
                            Console.Clear() ;
                            Console.WriteLine( "modelo do secador de cabelo" );
                            Console.WriteLine( "1-secador de cabelo simples" );
                            Console.WriteLine( "2-secador de cabelo medio" );
                            Console.WriteLine( "3-secador de cabelo proficional" );

                            
                            secc=Console.ReadLine() ;


                            if (secc == "1")
                            {
                                sec = 1000;
                            }
                            else if (secc == "2")
                            {
                                sec = 1500;
                            }
                            else if (secc == "3")
                            {
                                sec = 2000;
                            }
                            else { Console.WriteLine( "opicao invalida" ); break; }


                            Console.WriteLine( "quantidade de secador de cabelo" );
                            
                            sec1=int.Parse(Console.ReadLine());
                            // secres=sec*sec1;
                            break;
                        case 3:
                            Console.Clear() ;
                            Console.WriteLine( "modelo da chapa de cabelo" );
                            Console.WriteLine( "1-chapa de cabelo simples" );
                            Console.WriteLine( "2-chapa de cabelo proficional" );

                            chapc=Console.ReadLine() ;

                            if (chapc == "1")
                            {
                                chap = 200;
                            }
                            else if (chapc == "2")
                            {
                                chap = 500;
                            }
                            else { Console.WriteLine( "opicao invalida" ); break; }

                            Console.WriteLine( "quantidade de chapa de cabelo" );
                            chap1=int.Parse(Console.ReadLine());
                            // chapres=chap*chap1;
                            break;
                        case 4:
                            Console.Clear() ;
                            Console.WriteLine( "tipo do aquecedor de agua" );
                            Console.WriteLine( "1-aquecedor de agua" );
                            Console.WriteLine( "2-aquecedor de agua de banheira 127 volts" );
                            Console.WriteLine( "3-aquecedor de agua de banheira 220 volts" );
                            Console.WriteLine( "4-aquecedor de agua de pasagem" );

                            aquc=Console.ReadLine() ;


                            if (aquc == "1")
                            {
                                aqu = 2000;
                            }
                            else if (aquc == "2")
                            {
                                aqu = 5000;
                            }
                            else if (aquc == "3")
                            {
                                aqu = 8000;
                            }
                            else if (aquc == "4")
                            {
                                aqu = 6000;
                            }
                            else { Console.WriteLine( "opicao invalida" ); break; }

                            Console.WriteLine( "quantidade de aquecedor de agua" );
                            aqu1=int.Parse(Console.ReadLine());
                            //aqures=aqu*aqu1;
                            break;
                        case 5:
                            Console.Clear() ;
                            Console.WriteLine( "modelo da lampada" );
                            Console.WriteLine( "1-lampada led" );
                            Console.WriteLine( "2-lampada incandescente" );
                            Console.WriteLine( "3-lampada fluorescente" );
                            Console.WriteLine( "4-lampada tubular" );
                            Console.WriteLine( "5-lustre" );

                            lambc=Console.ReadLine() ;


                            if (lambc == "1")
                            {
                                lamb = 10;
                            }
                            else if (lambc == "2")
                            {
                                lamb = 100;
                            }
                            else if (lambc == "3")
                            {
                                lamb = 23;
                            }
                            else if (lambc == "4")
                            {
                                lamb = 40;
                            }
                            else if (lambc == "5")
                            {
                                lamb = 100;
                            }
                            else { Console.WriteLine( "opicao invalida" ); break; }

                            Console.WriteLine( "quantidade de lampada" );
                            lamb1=int.Parse(Console.ReadLine());
                            //lambres=lamb*lamb1;
                            break;

                    }

                    break;

                case 4:
                    Console.Clear() ;
                    Console.WriteLine( "1-lampadas" );
                    Console.WriteLine( "2-aquecedores de de picina " );
                    Console.WriteLine( "3-churrasqueira elerica" );


                    opcc=Console.ReadLine() ;

                    if (opcc == "1") { opc = 1; }
                    else if (opcc == "2") { opc = 2; }
                    else if (opcc == "3") { opc = 3; }
                    else { Console.WriteLine( "opicao invalida" ); break; }



                    switch (opc)
                    {
                        case 1:
                            Console.Clear() ;
                            Console.WriteLine( "modelo da lampada" );
                            Console.WriteLine( "1-lampada led" );
                            Console.WriteLine( "2-lampada incandescente" );
                            Console.WriteLine( "3-lampada fluorescente" );
                            Console.WriteLine( "4-lampada tubular" );
                            Console.WriteLine( "5-lustre" );

                            lquimc=Console.ReadLine() ;


                            if (lquimc == "1")
                            {
                                lquim = 10;
                            }
                            else if (lquimc == "2")
                            {
                                lquim = 100;
                            }
                            else if (lquimc == "3")
                            {
                                lquim = 23;
                            }
                            else if (lquimc == "4")
                            {
                                lquim = 40;
                            }
                            else if (lquimc == "5")
                            {
                                lquim = 100;
                            }
                            else { Console.WriteLine( "opicao invalida" ); break; }

                            Console.WriteLine( "quantidade de lampada" );
                            lquim1=int.Parse(Console.ReadLine());
                            // lquimres=lquim*lquim1;
                            break;
                        case 2:
                            Console.Clear() ;
                            Console.WriteLine( "modelo do aquecedor de picina 127 volts" );
                            Console.WriteLine( "1-aquecedor de picina 127 volts" );
                            Console.WriteLine( "2-aquecedor de picina 220 volts" );

                            aquqs=Console.ReadLine() ;


                            if (aquqs == "1")
                            {
                                aquq = 2000;
                            }
                            else if (aquqs == "2")
                            {
                                aquq = 5000;
                            }
                            else { Console.WriteLine( "opicao invalida" ); break; }

                            Console.WriteLine( "quantidade de aquecedor de picina " );
                            aquq1=int.Parse(Console.ReadLine());
                            // aquqres=aquq*aquq1;
                            break;
                        case 3:
                            Console.Clear() ;
                            Console.WriteLine( "modelo da churrasqueira" );
                            Console.WriteLine( "1-churrasqueira 127 volts" );
                            Console.WriteLine( "2-churrasqueira 220 volts" );

                            churrs=Console.ReadLine() ;



                            if (churrs == "1")
                            {
                                churr = 1500;
                            }
                            else if (churr == 2)
                            {
                                churr = 3000;
                            }
                            else { Console.WriteLine( "opicao invalida" ); break; }

                            Console.WriteLine( "quantidade de churrasqueiras" );
                            churr1=int.Parse(Console.ReadLine());
                            // churrres=churr*churr1;
                            break;

                    }


                    break;

                case 5:
                    Console.Clear() ;
                    Console.WriteLine( "1-lampadas" );
                    Console.WriteLine( "2-cafeteira" );
                    Console.WriteLine( "3-geladeira" );
                    Console.WriteLine( "4-fogao electrico" );
                    Console.WriteLine( "5-microondas" );
                    Console.WriteLine( "6-forno elétrico" );
                    Console.WriteLine( "7-torradeira" );
                    Console.WriteLine( "8-torneira eletrica" );
                    Console.WriteLine( "9-enbulidor" );
                    Console.WriteLine( "10-espremedor de frutas" );
                    Console.WriteLine( "11-ar condicionado" );
                    Console.WriteLine( "12-batedeira" );
                    Console.WriteLine( "13-liquidificador" );


                     opcc=Console.ReadLine() ;

                    if (opcc == "1") { opc = 1; }
                    else if (opcc == "2") { opc = 2; }
                    else if (opcc == "3") { opc = 3; }
                    else if (opcc == "4") { opc = 4; }
                    else if (opcc == "5") { opc = 5; }
                    else if (opcc == "6") { opc = 6; }
                    else if (opcc == "7") { opc = 6; }
                    else if (opcc == "8") { opc = 6; }
                    else if (opcc == "9") { opc = 6; }
                    else if (opcc == "10") { opc = 6; }
                    else if (opcc == "11") { opc = 6; }
                    else if (opcc == "12") { opc = 6; }
                    else if (opcc == "13") { opc = 6; }
                    else { Console.WriteLine( "opicao invalida" ); break; }





                    switch (opc)
                    {
                        case 1:
                            Console.Clear() ;
                            Console.WriteLine( "modelo da lampada" );
                            Console.WriteLine( "1-lampada led" );
                            Console.WriteLine( "2-lampada incandescente" );
                            Console.WriteLine( "3-lampada fluorescente" );
                            Console.WriteLine( "4-lampada tubular" );
                            Console.WriteLine( "5-lustre" );

                            lcozc=Console.ReadLine();


                            if (lcozc == "1")
                            {
                                lcoz = 10;
                            }
                            else if (lcozc == "2")
                            {
                                lcoz = 100;
                            }
                            else if (lcozc == "3")
                            {
                                lcoz = 23;
                            }
                            else if (lcozc == "4")
                            {
                                lcoz = 40;
                            }
                            else if (lcozc == "5")
                            {
                                lcoz = 100;
                            }
                            else { Console.WriteLine( "opicao invalida" ); break; }

                            Console.WriteLine( "quantidade de lampada" );
                            lcoz1=int.Parse( Console.ReadLine() );
                            // lcozres=lcoz*lcoz1;
                            break;
                        case 2:
                            Console.Clear() ;
                            Console.WriteLine( "modelo da cafeteira" );
                            Console.WriteLine( "1-cafeteira simples" );
                            Console.WriteLine( "2-cafeteira Industrial  20 litros" );

                            cafecs=Console.ReadLine();


                            if (cafecs == "1")
                            {
                                cafec = 500;
                            }
                            else if (cafecs == "2")
                            {
                                cafec = 4000;
                            }
                            else { Console.WriteLine( "opicao invalida" ); break; }

                            Console.WriteLine( "quantidade de cafeteira" );
                            cafec1=int.Parse( Console.ReadLine() );
                            // cafecres=cafec*cafec1;
                            break;
                        case 3:
                            Console.Clear() ;
                            Console.WriteLine( "modelo da geladeira" );
                            Console.WriteLine( "1-geladeira simples" );
                            Console.WriteLine( "2-geladeira duplex" );
                            Console.WriteLine( "3-freezer vertical" );
                            Console.WriteLine( "4-freezer horizontal" );

                            gelcs=Console.ReadLine();



                            if (gelcs == "1")
                            {
                                gelc = 200;
                            }
                            else if (gelcs == "2")
                            {
                                gelc = 500;
                            }
                            else if (gelcs == "3")
                            {
                                gelc = 300;
                            }
                            else if (gelcs == "4")
                            {
                                gelc = 500;
                            }
                            else { Console.WriteLine( "opicao invalida" ); break; }

                            Console.WriteLine( "quantidade de geladeira" );
                            gelc1=int.Parse( Console.ReadLine() );
                            // gelcres=gelc*gelc1;
                            break;
                        case 4:
                            Console.Clear() ;
                            Console.WriteLine( "modelo do fogao electrico" );
                            Console.WriteLine( "1-fogao electrico 1 bocas" );
                            Console.WriteLine( "2-fogao electrico 2 bocas" );
                            Console.WriteLine( "3-fogao electrico 4 bocas" );


                            fogcs=Console.ReadLine();


                            if (fogcs == "1")
                            {
                                fogc = 1000;
                            }
                            else if (fogcs == "2")
                            {
                                fogc = 3000;
                            }
                            else if (fogcs == "3")
                            {
                                fogc = 6000;
                            }
                            else { Console.WriteLine( "opicao invalida" ); break; }

                            Console.WriteLine( "quantidade de fogao electrico" );
                            fogc1=int.Parse( Console.ReadLine() );
                            //fogcres=fogc*fogc1;
                            break;
                        case 5:
                            Console.Clear() ;
                            Console.WriteLine( "modelo do microondas" );
                            Console.WriteLine( "1-microondas 20 litros" );
                            Console.WriteLine( "2-microondas 30 litros" );
                            Console.WriteLine( "3-microondas maior que 30 litros" );
                            Console.WriteLine( "4-microondas menor que 20 litros" );


                             miccs=Console.ReadLine();


                            if (miccs == "1")
                            {
                                micc = 1150;
                            }
                            else if (miccs == "2")
                            {
                                micc = 1500;
                            }
                            else if (miccs == "3")
                            {
                                micc = 3000;
                            }
                            else if (miccs == "4")
                            {
                                micc = 500;
                            }
                            else { Console.WriteLine( "opicao invalida" ); break; }

                            Console.WriteLine( "quantidade de microondas" );
                             micc1=int.Parse( Console.ReadLine() );
                            //miccres=micc*micc1;
                            break;
                        case 6:
                            Console.Clear() ;
                            Console.WriteLine( "modelo do forno elétrico" );
                            Console.WriteLine( "1-forno elétrico pequeno" );
                            Console.WriteLine( "2-forno elétrico grande" );

                            forcs=Console.ReadLine();

                            if (forcs == "1")
                            {
                                forc = 1500;
                            }
                            else if (forcs == "2")
                            {
                                forc = 4500;
                            }
                            else { Console.WriteLine( "opicao invalida" ); break; }

                            Console.WriteLine( "quantidade de forno elétrico" );
                            forc1=int.Parse( Console.ReadLine() );
                            // forcres=forc*forc1;
                            break;
                        case 7:
                            Console.Clear() ;
                            Console.WriteLine( "modelo da torradeira" );
                            Console.WriteLine( "1-torradeira simples" );
                            Console.WriteLine( "2-torradeira 220 volt" );

                            torcs=Console.ReadLine();


                            if (torcs == "1")
                            {
                                torc = 4500;
                            }
                            else if (torcs == "2")
                            {
                                torc = 6000;
                            }
                            else { Console.WriteLine( "opicao invalida" ); break; }

                            Console.WriteLine( "quantidade de torradeira" );
                            torc1=int.Parse( Console.ReadLine() );
                            // torcres=torc*torc1;
                            break;
                        case 8:
                            Console.Clear() ;
                            Console.WriteLine( "modelo da torrneira" );
                            Console.WriteLine( "1-torrneira simples" );
                            Console.WriteLine( "2-torrneira 220 volt" );

                             trns=Console.ReadLine();


                            if (trns == "1")
                            {
                                trn = 2600;
                            }
                            else if (trns == "2")
                            {
                                trn = 3600;
                            }
                            else { Console.WriteLine( "opicao invalida" ); break; }

                            Console.WriteLine( "quantidade de torrneira" );
                             trn1=int.Parse( Console.ReadLine() );
                            // trnres=trn*trn1;
                            break;
                        case 9:
                            Console.Clear() ;
                            Console.WriteLine( "modelo do enbulido" );
                            Console.WriteLine( "1-enbulido simples" );
                            Console.WriteLine( "2-enbulido 220 volt" );

                             enbcs=Console.ReadLine();


                            if (enbcs == "1")
                            {
                                enbc = 1000;
                            }
                            else if (enbcs == "2")
                            {
                                enbc = 2000;
                            }
                            else { Console.WriteLine( "opicao invalida" ); break; }

                            Console.WriteLine( "quantidade de enbulido" );
                            enbc1=int.Parse( Console.ReadLine() );
                            //enbcres=enbc*enbc1;
                            break;
                        case 10:
                            Console.Clear() ;
                            Console.WriteLine( "modelo espremedor de frutas" );
                            Console.WriteLine( "1-espremedor de frutas simples" );
                            Console.WriteLine( "2-espremedor de frutas 220 volt" );

                             espcs=Console.ReadLine();


                            if (espcs == "1")
                            {
                                espc = 200;
                            }
                            else if (espcs == "2")
                            {
                                espc = 500;
                            }
                            else { Console.WriteLine( "opicao invalida" ); break; }

                            Console.WriteLine( "quantidade de espremedor de frutas" );
                            espc1=int.Parse( Console.ReadLine() );
                            // espcres=espc*espc1;
                            break;
                        case 11:
                            Console.Clear() ;
                            Console.WriteLine( "modelo do ar condicionado" );
                            Console.WriteLine( "1-ar condicionado 7500btu" );
                            Console.WriteLine( "2-ar condicionado 10000btu" );
                            Console.WriteLine( "3-ar condicionado 12000btu" );
                            Console.WriteLine( "4-ar condicionado 15000btu" );
                            Console.WriteLine( "5-ventilador de teto" );
                            Console.WriteLine( "6-ventilador " );

                             arcs=Console.ReadLine();


                            if (arcs == "1")
                            {
                                arc = 1000;
                            }
                            else if (arcs == "2")
                            {
                                arc = 1350;
                            }
                            else if (arcs == "3")
                            {
                                arc = 1500;
                            }
                            else if (arcs == "4")
                            {
                                arc = 2000;
                            }
                            else if (arcs == "5")
                            {
                                arc = 120;
                            }
                            else if (arcs == "6")
                            {
                                arc = 100;
                            }
                            else { Console.WriteLine( "opicao invalida" ); break; }

                            Console.WriteLine( "quantidade de ar condicionado" );
                            arc1=int.Parse( Console.ReadLine() );
                            //arcrs=arc*arc1;
                            break;
                        case 12:
                            Console.Clear() ;
                            Console.WriteLine( "modelo da batedeira" );
                            Console.WriteLine( "1-batedeira simples" );
                            Console.WriteLine( "2-batedeira 220 volt" );

                            batcs=Console.ReadLine();


                            if (batcs == "1")
                            {
                                batc = 500;
                            }
                            else if (batcs == "2")
                            {
                                batc = 750;
                            }
                            else { Console.WriteLine( "opicao invalida" ); break; }

                            Console.WriteLine( "quantidade de batedeira" );
                            batc1=int.Parse( Console.ReadLine() );
                            // batcres=batc*batc1;
                            break;
                        case 13:
                            Console.Clear() ;
                            Console.WriteLine( "modelo do liquidificador" );
                            Console.WriteLine( "1-liquidificador simples" );
                            Console.WriteLine( "2-liquidificador 220 volt" );

                             liqcs=Console.ReadLine();


                            if (liqcs == "1")
                            {
                                liqc = 500;
                            }
                            else if (liqcs == "2")
                            {
                                liqc = 750;
                            }
                            else { Console.WriteLine( "opicao invalida" ); break; }

                            Console.WriteLine( "quantidade de liquidificador" );
                            liqc1=int.Parse( Console.ReadLine() );
                            // liqcres=liqc*liqc1;
                            break;

                    }

                    break;

                case 6:
                    Console.Clear() ;
                    Console.WriteLine( "1-enceradeira" );
                    Console.WriteLine( "2-aspirador de po" );

                     opcc=Console.ReadLine();
                    if (opcc == "1") { opc = 1; }
                    else if (opcc == "2") { opc = 2; }
                    else { Console.WriteLine( "opicao invalida" ); break; }


                    switch (opc)
                    {
                        case 1:
                            Console.Clear() ;
                            Console.WriteLine( "modelo da enceradeira" );
                            Console.WriteLine( "1-enceradeira 127 volts" );
                            Console.WriteLine( "2-enceradeira 220 volts" );


                            encs=Console.ReadLine();


                            if (encs == "1")
                            {
                                enc = 500;
                            }
                            else if (encs == "2") { enc = 1000; }// encres=enc*enc1; 
                            else { Console.WriteLine( "opicao invalida" ); break; }

                            Console.WriteLine( "quantidade de enceradeira" );
                             enc1=int.Parse( Console.ReadLine() );

                            break;
                        case 2:
                            Console.Clear() ;
                            Console.WriteLine( "modelo do aspirador de po" );
                            Console.WriteLine( "1-aspirador de po simples" );
                            Console.WriteLine( "2-aspirador de po 220 volt" );

                            asps=Console.ReadLine();

                            if (asps == "1")
                            {
                                asp = 1500;
                            }
                            else if (asps == "2")
                            {
                                asp = 2000;   //  aspres=asp*asp1;
                            }
                            else { Console.WriteLine( "opicao invalida" ); break; }

                            Console.WriteLine( "quantidade de aspirador de po" );
                             asp1=int.Parse( Console.ReadLine() );
                            break;

                    }

                    break;
                case 7:
                    Console.Clear() ;
                    Console.WriteLine( "1-impresora" );
                    Console.WriteLine( "2-coputador" );
                    Console.WriteLine( "3-lampadas" );
                    Console.WriteLine( "4-ar condicionado" );


                    opcc=Console.ReadLine();

                    if (opcc == "1") { opc = 1; }
                    else if (opcc == "2") { opc = 2; }
                    else if (opcc == "3") { opc = 3; }
                    else if (opcc == "4") { opc = 4; }
                    else { Console.WriteLine( "opicao invalida" ); break; }

                    switch (opc)
                    {
                        case 1:
                            Console.WriteLine( "modelo da impresora" );
                            Console.WriteLine( "1-impresora multifuncional" );
                            Console.WriteLine( "2-impresora laser" );
                            Console.WriteLine( "3-impresora grade" );
                            Console.WriteLine( "4-impresora 3d" );


                             imps= Console.ReadLine( );   


                            if (imps == "1")
                            {
                                imp = 400;
                            }
                            else if (imps == "2")
                            {
                                imp = 600;
                            }
                            else if (imps == "3")
                            {
                                imp = 1000;
                            }
                            else if (imps == "4")
                            {
                                imp = 1500;
                            }
                            else { Console.WriteLine( "opicao invalida" ); break; }

                            Console.WriteLine( "quantidade de impresora" );
                            imp1=int.Parse( Console.ReadLine() );
                            // impres=imp*imp1;
                            break;
                        case 2:
                            Console.WriteLine( "modelo do coputador" );
                            Console.WriteLine( "1-coputador simples" );
                            Console.WriteLine( "2-coputador gamer" );
                            Console.WriteLine( "3-coputador escritorio" );

                            cops=Console.ReadLine( );

                            if (cops == "1")
                            {
                                cop = 300;
                            }
                            else if (cops == "2")
                            {
                                cop = 500;
                            }
                            else if (cops == "3")
                            {
                                cop = 400;
                            }
                            else { Console.WriteLine( "opicao invalida" ); break; }

                            Console.WriteLine( "quantidade de coputador" );
                             cop1=int.Parse( Console.ReadLine() );
                            // copres=cop*cop1;
                            break;
                        case 3:
                            Console.WriteLine( "modelo das lampadas" );
                            Console.WriteLine( "1-lampada led" );
                            Console.WriteLine( "2-lampada incandescente" );
                            Console.WriteLine( "3-lampada fluorescente" );
                            Console.WriteLine( "4-lampada tubular" );
                            Console.WriteLine( "5-lampada lustre" );

                             les=Console.ReadLine( );


                            if (les == "1")
                            {
                                le = 10;
                            }
                            else if (les == "2")
                            {
                                le = 100;
                            }
                            else if (les == "3")
                            {
                                le = 20;
                            }
                            else if (les == "4")
                            {
                                le = 40;
                            }
                            else if (les == "5")
                            {
                                le = 50;
                            }
                            else { Console.WriteLine( "opicao invalida" ); break; }

                            Console.WriteLine( "quantidade de lampadas" );
                             le1=int.Parse( Console.ReadLine() );
                            // leres=le*le1;
                            break;
                        case 4:
                            Console.WriteLine( "modelo do ar condicionado" );
                            Console.WriteLine( "1-ar condicionado 75000 btu" );
                            Console.WriteLine( "2-ar condicionado 150000 btu" );
                            Console.WriteLine( "3-ar condicionado 120000 btu" );
                            Console.WriteLine( "4-ar condicionado siples" );
                            Console.WriteLine( "5-ventilador de teto" );
                            Console.WriteLine( "6-ventilador siples" );
                            Console.WriteLine( "7-ar condicionado 180000 btu" );


                             ares=Console.ReadLine( );


                            if (ares == "1")
                            {
                                are = 1000;
                            }
                            else if (ares == "2")
                            {
                                are = 2000;
                            }
                            else if (ares == "3")
                            {
                                are = 1500;
                            }
                            else if (ares == "4")
                            {
                                are = 500;
                            }
                            else if (ares == "5")
                            {
                                are = 120;
                            }
                            else if (ares == "6")
                            {
                                are = 100;
                            }
                            else if (ares == "7")
                            {
                                are = 2100;
                            }
                            else { Console.WriteLine( "opicao invalida" ); break; }

                            Console.WriteLine( "quantidade de ar condicionado" );
                             are1=int.Parse( Console.ReadLine() );
                            // areres=are*are1;
                            break;

                    }


                    break;
                case 8:
                    Console.Clear() ;
                    Console.WriteLine( "1-maquina de lavar" );
                    Console.WriteLine( "2-ferro de passar" );
                    Console.WriteLine( "3-maquina de secar" );
                    Console.WriteLine( "4-maquina de lavar e secar" );
                    Console.WriteLine( "5-lampadas" );

                     opcc=Console.ReadLine();

                    if (opcc == "1") { opc = 1; }
                    else if (opcc == "2") { opc = 2; }
                    else if (opcc == "3") { opc = 3; }
                    else if (opcc == "4") { opc = 4; }
                    else if (opcc == "5") { opc = 5; }
                    else { Console.WriteLine( "opicao invalida" ); break; }



                    switch (opc)
                    {
                        case 1:
                            Console.Clear() ;
                            Console.WriteLine( "modelo da maquina de lavar" );
                            Console.WriteLine( "1-maquina de lavar 8kg" );
                            Console.WriteLine( "2-maquina de lavar 10kg" );
                            Console.WriteLine( "3-maquina de lavar 12kg" );
                            Console.WriteLine( "4-maquina de lavar 14kg" );
                            Console.WriteLine( "5-maquina de lavar 16kg" );
                            Console.WriteLine( "6-maquina de lavar 18kg" );
                            Console.WriteLine( "7-maquina de lavar 20kg" );

                            lavs=Console.ReadLine();




                            if (lavs == "1")
                            {
                                lav = 200;
                            }
                            else if (lavs == "2")
                            {
                                lav = 400;
                            }
                            else if (lavs == "3")
                            {
                                lav = 500;
                            }
                            else if (lavs == "4")
                            {
                                lav = 600;
                            }
                            else if (lavs == "5")
                            {
                                lav = 700;
                            }
                            else if (lavs == "6")
                            {
                                lav = 800;
                            }
                            else if (lavs == "7") { lav = 900; }
                            else { Console.WriteLine( "opicao invalida" ); break; }

                            Console.WriteLine( "quantidade de maquina de lavar" );
                             lav1=int.Parse( Console.ReadLine() );
                            // lavres=lav*lav1;
                            break;
                        case 2:
                            Console.Clear() ;
                            Console.WriteLine( "modelo do ferro de passar" );
                            Console.WriteLine( "1-ferro de passar 127 volts" );
                            Console.WriteLine( "2-ferro de passar 220 volts" );

                             fers=Console.ReadLine();



                            if (fers == "1")
                            {
                                fer = 1000;
                            }
                            else if (fers == "2") { fer = 1500; }
                            else { Console.WriteLine( "opicao invalida" ); break; }

                            Console.WriteLine( "quantidade de ferro de passar" );
                             fer1=int.Parse( Console.ReadLine() );

                            //ferres=fer*fer1;
                            break;
                        case 3:
                            Console.Clear() ;
                            Console.WriteLine( "modelo da maquina de secar" );
                            Console.WriteLine( "1-maquina de secar 127 volts" );
                            Console.WriteLine( "2-maquina de secar 220 volts" );
                             secls=Console.ReadLine();



                            if (secls == "1") { secl = 1500; } else if (secls == "2") { secl = 3500; } else { Console.WriteLine( "opicao invalida" ); break; }

                            Console.WriteLine( "quantidade de maquina de secar" );
                            secl1=int.Parse( Console.ReadLine() );

                            //seclres=secl*secl1;
                            break;
                        case 4:
                            Console.Clear() ;
                            Console.WriteLine( "modelo da maquina de lavar e secar" );
                            Console.WriteLine( "1-maquina de lavar e secar 8kg" );
                            Console.WriteLine( "2-maquina de lavar e secar 10kg" );
                            Console.WriteLine( "3-maquina de lavar e secar 12kg" );
                            Console.WriteLine( "4-maquina de lavar e secar 14kg" );
                            Console.WriteLine( "5-maquina de lavar e secar 16kg" );
                            Console.WriteLine( "6-maquina de lavar e secar 18kg" );
                            Console.WriteLine( "7-maquina de lavar e secar 20kg" );

                             lavses=Console.ReadLine();


                            if (lavses == "1")
                            {
                                lavse = 1000;
                            }
                            else if (lavses == "2")
                            {
                                lavse = 1500;
                            }
                            else if (lavses == "3")
                            {
                                lavse = 2000;
                            }
                            else if (lavses == "4")
                            {
                                lavse = 2500;
                            }
                            else if (lavses == "5")
                            {
                                lavse = 3000;
                            }
                            else if (lavses == "6")
                            {
                                lavse = 3500;
                            }
                            else if (lavses == "7") { lavse = 4000; }
                            else { Console.WriteLine( "opicao invalida" ); break; }

                            Console.WriteLine( "quantidade de maquina de lavar e secar" );
                            lavse1=int.Parse(Console.ReadLine());


                            // lavseres=lavse*lavse1;                        

                            break;
                        case 5:
                            Console.Clear() ;
                            Console.WriteLine( "modelo da lampada" );
                            Console.WriteLine( "1-led" );
                            Console.WriteLine( "2-encadecete amarela" );
                            Console.WriteLine( "3-fluorescente" );
                            Console.WriteLine( "4-lustre" );
                            Console.WriteLine( "5-tubular" );
                             lss=Console.ReadLine();



                            if (lss == "1")
                            {
                                lam = 10;
                            }
                            else if (lss == "2")
                            {
                                lam = 100;
                            }
                            else if (lss == "3")
                            {
                                lam = 23;
                            }
                            else if (lss == "4")
                            {
                                lam = 100;
                            }
                            else if (lss == "5")
                            {
                                lam = 40;
                            }
                            else { Console.WriteLine( "opicao invalida" ); break; }
                            break;

                            Console.WriteLine( "quantidade de lampadas" );
                             ls1=int.Parse(Console.ReadLine());




                    }


                    break;
                case 9:
                    Console.Clear() ;
                    Console.WriteLine( "tipo de ferramentas" );
                    Console.WriteLine( "1-cortador de grama" );
                    Console.WriteLine( "2-aspirador " );
                    Console.WriteLine( "3-bomba de agua" );
                    Console.WriteLine( "4-furadeira" );
                    Console.WriteLine( "5-makita" );
                    Console.WriteLine( "6-serra elétrica" );
                    Console.WriteLine( "7-copressor" );
                    Console.WriteLine( "8-ferro de solda" );




                     opcc=Console.ReadLine();

                    if (opcc == "1") { opc = 1; }
                    else if (opcc == "2") { opc = 2; }
                    else if (opcc == "3") { opc = 3; }
                    else if (opcc == "4") { opc = 4; }
                    else if (opcc == "5") { opc = 5; }
                    else if (opcc == "6") { opc = 6; }
                    else if (opcc == "7") { opc = 6; }
                    else if (opcc == "8") { opc = 6; }
                    else { Console.WriteLine( "opicao invalida" ); break; }

                    switch (opc)
                    {
                        case 1:
                            Console.Clear() ;
                            Console.WriteLine( "modelo do cortador de grama" );
                            Console.WriteLine( "1-cortador de grama 127 volts" );
                            Console.WriteLine( "2-cortador de grama 220 volts" );

                            corts=Console.ReadLine() ;


                            if (corts == "1") { cort = 500; } else if (corts == "2") { cort = 1000; } else { Console.WriteLine( "opicao invalida" ); break; }

                            Console.WriteLine( "quantidade de cortador de grama" );
                            cort1=int.Parse(Console.ReadLine()) ;

                            //cortres=cort*cort1;
                            break;
                        case 2:
                            Console.Clear() ;
                            Console.WriteLine( "modelo do aspirador" );
                            Console.WriteLine( "1-aspirador pequeno" );
                            Console.WriteLine( "2-aspirador grande" );
                            Console.WriteLine( "3-aspirador robotico" );

                             aspc=Console.ReadLine() ;

                            if (aspc == "1")
                            {
                                asp = 500;
                            }
                            else if (aspc == "2")
                            {
                                asp = 1500;
                            }
                            else if (aspc == "3") { asp = 100; }
                            else { Console.WriteLine( "opicao invalida" ); break; }

                            Console.WriteLine( "quantidade de aspirador" );
                            asp1=int.Parse(Console.ReadLine()) ;
                            //aspres=asp*asp1;                     
                            break;
                        case 3:
                            Console.Clear() ;
                            Console.WriteLine( "modelo da bomba de agua" );
                            Console.WriteLine( "1-bomba de agua 127 volts" );
                            Console.WriteLine( "2-bomba de agua 220 volts" );

                             boms=Console.ReadLine() ;

                            if (boms == "1")
                            {
                                bom = 500;
                            }
                            else if (boms == "2") { bom = 1000; }
                            else { Console.WriteLine( "opicao invalida" ); break; }

                            Console.WriteLine( "quantidade de bomba de agua" );
                            bom1=int.Parse(Console.ReadLine()) ;
                            //bomres=bom*bom1;
                            break;
                        case 4:
                            Console.Clear() ;
                            Console.WriteLine( "modelo da furadeira" );
                            Console.WriteLine( "1-furadeira com impacto" );
                            Console.WriteLine( "2-furadeira sem impacto" );

                             furs=Console.ReadLine() ;


                            if (furs == "1")
                            {
                                fur = 500;
                            }
                            else if (furs == "2") { fur = 1000; }
                            else { Console.WriteLine( "opicao invalida" ); break; }

                            Console.WriteLine( "quantidade de furadeira" );
                             fur1=int.Parse(Console.ReadLine()) ;

                            //furres=fur*fur1;
                            break;
                        case 5:
                            Console.Clear() ;
                            Console.WriteLine( "modelo da makita" );
                            Console.WriteLine( "1-makita 127 volts" );
                            Console.WriteLine( "2-makita 220 volts" );

                             maks=Console.ReadLine() ;



                            if (maks == "1")
                            {
                                mak = 1000;
                            }
                            else if (maks == "2") { mak = 1500; }
                            else { Console.WriteLine( "opicao invalida" ); break; }

                            Console.WriteLine( "quantidade de makita" );
                             mak1=int.Parse(Console.ReadLine()) ;

                            // makres=mak*mak1;
                            break;
                        case 6:
                            Console.Clear() ;
                            Console.WriteLine( "modelo da serra elétrica" );
                            Console.WriteLine( "1-serra elétrica tico tico" );
                            Console.WriteLine( "2-serra elétrica circular" );
                            Console.WriteLine( "3-serra elétrica sabre" );
                            Console.WriteLine( "4-serra elétrica de mesa" );
                            Console.WriteLine( "5-moto serra eletrica" );

                             sers=Console.ReadLine() ;



                            if (sers == "1")
                            {
                                ser = 700;
                            }
                            else if (sers == "2")
                            {
                                ser = 1600;
                            }
                            else if (sers == "3")
                            {
                                ser = 1000;
                            }
                            else if (sers == "4")
                            {
                                ser = 2200;
                            }
                            else if (sers == "5") { ser = 3000; }
                            else { Console.WriteLine( "opicao invalida" ); break; }

                            Console.WriteLine( "quantidade de serra elétrica" );
                             ser1=int.Parse(Console.ReadLine()) ;
                            //serres=ser*ser1;
                            break;
                        case 7:
                            Console.Clear() ;
                            Console.WriteLine( "modelo do copressor" );
                            Console.WriteLine( "1-copressor pequeno" );
                            Console.WriteLine( "2-copressor medio" );
                            Console.WriteLine( "3-copressor grande" );

                             copfs=Console.ReadLine() ;


                            if (copfs == "1")
                            {
                                copf = 500;
                            }
                            else if (copfs == "2")
                            {
                                copf = 1000;
                            }
                            else if (copfs == "3") { copf = 1500; }
                            else { Console.WriteLine( "opicao invalida" ); break; }

                            Console.WriteLine( "quantidade de copressor" );
                             copf1=int.Parse(Console.ReadLine()) ;
                            //copfres=copf*copf1;
                            break;
                        case 8:
                            Console.Clear() ;
                            Console.WriteLine( "modelo do ferro de solda" );
                            Console.WriteLine( "1-ferro de solda 127 volts" );
                            Console.WriteLine( "2-ferro de solda 220 volts" );

                             ferfs=Console.ReadLine() ;

                            if (ferfs == "1")
                            {
                                ferf = 1000;
                            }
                            else if (ferfs == "2") { ferf = 1500; }
                            else { Console.WriteLine( "opicao invalida" ); break; }

                            Console.WriteLine( "quantidade de ferro de solda" );
                             ferf1=int.Parse(Console.ReadLine()) ;
                            // ferfres=ferf*ferf1;
                            break;


                    }


                    break;
                case 10:
                    Console.Clear() ;
                    Console.WriteLine( "1-telefone celular" );
                    Console.WriteLine( "2-slide" );
                    Console.WriteLine( "3-adiciona watts manualmente exemplo 1000" );

                     opcc=Console.ReadLine() ;

                    if (opcc == "1") { opc = 1; }
                    else if (opcc == "2") { opc = 2; }
                    else if (opcc == "3") { opc = 3; }

                    else { Console.WriteLine( "opicao invalida" ); break; }


                    switch (opc)
                    {
                        case 1:
                            Console.Clear() ;
                            Console.WriteLine( "modelo do telefone celular" );
                            Console.WriteLine( "1-telefone celular" );

                            telc=Console.ReadLine() ;


                            if (telc == "1") { tel = 5; }
                            if (opcc == "1") { opc = 1; }

                            else { Console.WriteLine( "opicao invalida" ); break; }

                            Console.WriteLine( "quantidade de telefone celular" );
                             tel1=int.Parse(Console.ReadLine()) ;
                            //telres=tel*tel1;
                            break;
                        case 2:
                            Console.Clear() ;
                            Console.WriteLine( "modelo do slide" );
                            Console.WriteLine( "1-slide" );

                             slids=Console.ReadLine() ;

                            if (slids == "1") { slid = 200; }
                            else { Console.WriteLine( "opicao invalida" ); break; }

                            Console.WriteLine( "quantidade de slide" );
                             slid1=int.Parse(Console.ReadLine()) ;
                            // slidres=slid*slid1;
                            break;
                        case 3:
                            Console.Clear() ;
                            Console.WriteLine( "quantidade de watss" );
                             watts=int.Parse(Console.ReadLine()) ;
                            break;



                    }

                    break;
                default:
                    Console.WriteLine( "opicao invalida" );

                    break;



            }



            Console.WriteLine( "Deseja adicionar mais (s/n)" );
            perg=Console.ReadLine() ;

        }




        telres = tel * tel1; serres = ser * ser1; makres = mak * mak1; slidres = slid * slid1; ferfres = ferf * ferf1;
        copfres = copf * copf1; lavseres = lavse * lavse1; seclres = secl * secl1; impres = imp * imp1; aspres = asp * asp1;
        furres = fur * fur1; cortres = cort * cort1; ferres = fer * fer1; aspres = asp * asp1; encres = enc * enc1;
        bomres = bom * bom1; leres = le * le1; lavres = lav * lav1; copres = cop * cop1; batcres = batc * batc1;
        aspres = asp * asp1; seclres = secl * secl1; areres = are * are1; arcres = arc * arc1; espcres = espc * espc1;
        enbcres = enbc * enbc1; churrres = churr * churr1; lquimres = lquim * lquim1; aquqres = aquq * aquq1;
        trnres = trn * trn1; lambres = lamb * lamb1; aqures = aqu * aqu1; chapres = chap * chap1; secres = sec * sec1;
        torcres = torc * torc1; chbres = chb * chb1; comqres = comq * comq1; lamqres = lamq * lamq1; tvqres = tvq * tvq1;
        forcres = forc * forc1; arqres = arq * arq1; dvdsres = dvds * dvds1; vsalares = vsala * vsala1; gelcres = gelc * gelc1;
        miccres = micc * micc1; sonqres = sonq * sonq1; arres = ars * ars1; lcozres = lcoz * lcoz1; lampadasres = lampadas * lampadas1;
        fogcres = fogc * fogc1; sonsres = sons * sons1; tvsres = tvs * tvs1; cafecres = cafec * cafec1; lamres = lam * ls1;




        banheiores = chbres + secres + chapres + aqures + lambres; quintalres = lquimres + aquqres + churrres;
        quartores = tvqres + lamqres + arqres + sonqres + comqres; outrosres = telres + slidres + watts + encres + aspres;
        ferramentasres = cortres + aspres + bomres + furres + makres + serres + copfres + ferfres; cozinhares = lcozres + cafecres + gelcres + fogcres + miccres + forcres + enbcres + espcres + arcres + batcres + liqcres + trnres;
        salares = tvsres + lampadasres + arres + sonsres + vsalares + dvdsres; lavadeiriares = lavres + ferres + seclres + lavseres;
        iluminares = lamres + lambres + lamqres + lampadasres; escritoriores = impres + copres + leres + areres + lamres;
        //limpezares= encres,aspres; 

        res = encres + aspres + impres + copres + leres + tvs1 + arres + sonsres + churrres + trnres +
        tvqres + lamqres + arqres + sonqres + comqres + tvsres + lampadasres + chbres + secres + lamres +
        chapres + aqures + lambres + lquimres + aquqres + lcozres + vsalares + dvdsres + cafecres + gelcres +
        fogcres + miccres + forcres + torcres + enbcres + espcres + arcres + batcres + liqcres + lavres + ferres +
        seclres + lavseres + cortres + bomres + furres + makres + serres + copfres + ferfres + telres + slidres +
        watts + iluminares;






        if (iluminares <= 1000 && iluminares > 1) { djilum = 10; fioilu = 1.5f; } else if (iluminares >= 3000) { djilum = 25; fioilu = 2.5f; } else if (iluminares > 5000) { djilum = 40; fioilu = 4; }
        if (salares <= 1000 && salares > 1) { djs = 10; fios = 1.5f; } else if (salares >= 2000) { djs = 20; fios = 2.5f; } else if (salares >= 3000) { djs = 30; fios = 3; } else if (salares > 5000) { djs = 40; fios = 6; }
        if (quartores <= 1000 && quartores > 1) { djq = 10; fioq = 1.5f; } else if (quartores >= 2000) { djq = 20; fioq = 2.5f; } else if (quartores >= 3000) { djq = 30; fioq = 3; } else if (quartores > 5000) { djq = 40; fioq = 6; }
        if (quintalres <= 1000 && quintalres > 1) { djqui = 10; fioquim = 1.5f; } else if (quintalres >= 2000) { djqui = 20; fioquim = 2.5f; } else if (quintalres >= 3000) { djqui = 30; fioquim = 3; } else if (quintalres > 5000) { djqui = 40; fioquim = 6; }
        if (lavadeiriares <= 1000 && lavadeiriares > 1) { djl = 10; fiol = 1.5f; } else if (lavadeiriares >= 2000) { djl = 20; fiol = 2.5f; } else if (lavadeiriares >= 3000) { djl = 30; fiol = 3; } else if (lavadeiriares > 5000) { djl = 40; fiol = 6; }
        if (ferramentasres <= 1000 && ferramentasres > 1) { djfer = 10; fiofer = 1.5f; } else if (ferramentasres >= 3000) { djfer = 25; fiofer = 2.5f; } else if (ferramentasres > 5000) { djfer = 40; fiofer = 4; }
        if (escritoriores <= 1000 && escritoriores > 1) { dje = 10; fioe = 1.5f; } else if (escritoriores >= 3000) { dje = 25; fioe = 2.5f; } else if (escritoriores > 5000) { dje = 40; fioe = 4; }
        if (cozinhares <= 1000 && cozinhares > 1) { djc = 10; fioc = 1.5f; } else if (cozinhares >= 3000) { djc = 25; fioc = 2.5f; } else if (cozinhares > 5000) { djc = 40; fioc = 4; }
        if (banheiores <= 1000 && banheiores > 1) { djb = 10; fiob = 1.5f; } else if (banheiores >= 3000) { djb = 25; fiob = 2.5f; } else if (banheiores > 5000) { djb = 40; fiob = 4; }
        if (outrosres <= 1000 && outrosres > 1) { djo = 10; fioo = 1.5f; } else if (outrosres >= 3000) { djo = 25; fioo = 2.5f; } else if (outrosres > 5000) { djo = 40; fioo = 4; }


        if (res <= 8000) { djprim = 60; fiop = 10; } else if (res >= 7000) { djprim = 70; fiop = 12; }
        if (res > 12000) { djprim = 70; fiop = 10; } else if (res >= 16000) { djprim = 100; fiop = 14; }
        if (res > 16000) { djprim = 100; fiop = 14; } else if (res > 20000) { djprim = 120; fiop = 16; }

        

        if (res <= 8000) { padrao = 'm'; } else if (res > 8200) { padrao = 'b'; } else if (res > 16000) { padrao = 't'; }



      switch (padrao){
        case 'm':


                //i.reg();
                Console.WriteLine("-----------------------------------------------------");
                i.txt("padrao monofasico",'m');
                Console.WriteLine("-----------------------------------------------------");
                // Console.WriteLine("potencia da sala: {0}"  , salares +   "  watts " );
                //i.txt(string.Concat("potencia da sala: ", salares + "  watts "), 'r');
                // Console.WriteLine($"grana   {biel.grana}" + $"nome   {biel.nome}" + $"car   {biel.car}");





                if (salares > 1){i.txt(string.Concat("potencia da sala:  ", salares,"  watts"),'y');}
                if (quartores> 1) { i.txt(string.Concat("potencia dos quartosa:  ", quartores, "  watts"), 'y'); }
                if (quintalres > 1) { i.txt(string.Concat("potencia do quintal:  ", quintalres, "  watts"), 'y'); }
                if (lavadeiriares > 1) { i.txt(string.Concat("potencia da lavadeiria:  ", lavadeiriares, "  watts"), 'y'); }
                if (ferramentasres> 1) { i.txt(string.Concat("potencia das ferramantas:  ", ferramentasres, "  watts"), 'y'); }
                if (escritoriores > 1) { i.txt(string.Concat("potencia do escritorio:  ", escritoriores, "  watts"), 'y'); }
                if (cozinhares > 1) { i.txt(string.Concat("potencia da cozinha:  ", cozinhares, "  watts"), 'y'); }
                if (banheiores > 1) { i.txt(string.Concat("potencia do banheiro:  ", banheiores, "  watts"), 'y'); }
                if (outrosres > 1) { i.txt(string.Concat("potencia de outros:  ", outrosres, "  watts"), 'y'); }
                if (iluminares > 1) { i.txt(string.Concat("potencia da  iluminacao:  ", iluminares, "  watts"), 'y'); }
                
                
                if (res > 1) { i.txt(string.Concat("potencia total :  ", res, "  watts"), 'g'); }

                

                
           
            Console.WriteLine("-----------------------------------------------------");
            
            i.txt("dinjuntores:",'m');


                Console.WriteLine("-----------------------------------------------------");


                if (djo > 1) { i.txt(string.Concat("1 dinjunto de outros  ", djo, "  anperes"), 'y'); }
                if (djb > 1) { i.txt(string.Concat(" dinjunto do banheiro  ", djb, "  anperes"), 'y'); }
                if (djc > 1) { i.txt(string.Concat("1 dinjunto da cosinha  ", djc, "  anperes"), 'y'); }
                if (dje > 1) { i.txt(string.Concat("1 dinjunto do escritorio ", dje, "  anperes"), 'y'); }
                if (djl > 1) { i.txt(string.Concat("1 dinjunto da lavadeiria  ", djl, "  anperes"), 'y'); }
                if (djfer > 1) { i.txt(string.Concat("1 dinjunto de ferramentas ", djqui, "  anperes"), 'y'); }
                if (djqui > 1) { i.txt(string.Concat("1 dinjunto do quintal  ", djqui, "  anperes"), 'y'); }
                if (djq > 1) { i.txt(string.Concat(" dinjunto do quarto  ", djq, "  anperes"), 'y'); }
                if (djs > 1) { i.txt(string.Concat("1 dinjunto sala  ", djs, "  anperes"), 'y'); }
                if (djilum > 1) { i.txt(string.Concat("1 dinjunto iluminacao  ", djilum, "  anperes"), 'y'); }

                if (djprim > 1) { i.txt(string.Concat("1 dinjunto primcipal  ", djprim, "  anperes"), 'g'); }


                
            Console.WriteLine("-----------------------------------------------------");

            i.txt("fios:",'m');
                Console.WriteLine("-----------------------------------------------------");



                if (fioo > 1) { i.txt(string.Concat("bitola de fios de outros ", fioo, "  mm"), 'y'); }
                if (fioilu > 1) { i.txt(string.Concat("bitola de fios da iluminacao ", fioilu, "  mm"), 'y'); }
                if (fiob > 1) { i.txt(string.Concat("bitola de fios do banheiro", fiob, "  mm"), 'y'); }
                if (fioc > 1) { i.txt(string.Concat("bitola de fios da cozinha", fioc, "  mm"), 'y'); }
                if (fioe > 1) { i.txt(string.Concat("bitola de fios do escritorio ", fioe, "  mm"), 'y'); }
                if (fiofer > 1) { i.txt(string.Concat("bitola das ferramentas ", fiofer, "  mm"), 'y'); }
                if (fiol > 1) { i.txt(string.Concat("bitola de fios da lavadeiria", fiol, "  mm"), 'y'); }
                if (fioquim > 1) { i.txt(string.Concat("bitola de fios do quintal", fioquim, "  mm"), 'y'); }
                if (fioq > 1) { i.txt(string.Concat("bitola de fios dos quartos ", fioq, "  mm"), 'y'); }
                if (fios > 1) { i.txt(string.Concat("bitola de fios da sala ", fios, "  mm"), 'y'); }

                if (fiop > 1) { i.txt(string.Concat("bitola de fios primcipal ", fiop, "  mm"), 'g'); }

                

            
            
            
            
            
            
            
            
            
                  

            break;
        case 'b':
            



                
                Console.WriteLine("-----------------------------------------------------"); 
                i.txt("  padrao bifasico  ", 'm');
                Console.WriteLine("-----------------------------------------------------");
                // Console.WriteLine("potencia da sala: {0}"  , salares +   "  watts " );
                //i.txt(string.Concat("potencia da sala: ", salares + "  watts "), 'r');
                // Console.WriteLine($"grana   {biel.grana}" + $"nome   {biel.nome}" + $"car   {biel.car}");





                if (salares > 1) { i.txt(string.Concat("potencia da sala:  ", salares, "  watts"), 'y'); }
                if (quartores > 1) { i.txt(string.Concat("potencia dos quartosa:  ", quartores, "  watts"), 'y'); }
                if (quintalres > 1) { i.txt(string.Concat("potencia do quintal:  ", quintalres, "  watts"), 'y'); }
                if (lavadeiriares > 1) { i.txt(string.Concat("potencia da lavadeiria:  ", lavadeiriares, "  watts"), 'y'); }
                if (ferramentasres > 1) { i.txt(string.Concat("potencia das ferramantas:  ", ferramentasres, "  watts"), 'y'); }
                if (escritoriores > 1) { i.txt(string.Concat("potencia do escritorio:  ", escritoriores, "  watts"), 'y'); }
                if (cozinhares > 1) { i.txt(string.Concat("potencia da cozinha:  ", cozinhares, "  watts"), 'y'); }
                if (banheiores > 1) { i.txt(string.Concat("potencia do banheiro:  ", banheiores, "  watts"), 'y'); }
                if (outrosres > 1) { i.txt(string.Concat("potencia de outros:  ", outrosres, "  watts"), 'y'); }
                if (iluminares > 1) { i.txt(string.Concat("potencia da  iluminacao:  ", iluminares, "  watts"), 'y'); }

                
                if (res > 1) { i.txt(string.Concat("potencia total :  ", res, "  watts"), 'g'); }



                

                Console.WriteLine("-----------------------------------------------------");

                i.txt("dinjuntores:", 'm');


                Console.WriteLine("-----------------------------------------------------");


                if (djo > 1) { i.txt(string.Concat("1 dinjunto de outros  ", djo, "  anperes"), 'y'); }
                if (djb > 1) { i.txt(string.Concat(" dinjunto do banheiro  ", djb, "  anperes"), 'y'); }
                if (djc > 1) { i.txt(string.Concat("1 dinjunto da cosinha  ", djc, "  anperes"), 'y'); }
                if (dje > 1) { i.txt(string.Concat("1 dinjunto do escritorio ", dje, "  anperes"), 'y'); }
                if (djl > 1) { i.txt(string.Concat("1 dinjunto da lavadeiria  ", djl, "  anperes"), 'y'); }
                if (djfer > 1) { i.txt(string.Concat("1 dinjunto de ferramentas ", djqui, "  anperes"), 'y'); }
                if (djqui > 1) { i.txt(string.Concat("1 dinjunto do quintal  ", djqui, "  anperes"), 'y'); }
                if (djq > 1) { i.txt(string.Concat(" dinjunto do quarto  ", djq, "  anperes"), 'y'); }
                if (djs > 1) { i.txt(string.Concat("1 dinjunto sala  ", djs, "  anperes"), 'y'); }
                if (djilum > 1) { i.txt(string.Concat("1 dinjunto iluminacao  ", djilum, "  anperes"), 'y'); }

                if (djprim > 1) { i.txt(string.Concat("1 dinjunto primcipal  ", djprim, "  anperes"), 'g'); }

                
                Console.WriteLine("-----------------------------------------------------");
                i.txt("fios:", 'm');
                Console.WriteLine("-----------------------------------------------------");



                if (fioo > 1) { i.txt(string.Concat("bitola de fios de outros ", fioo, "  mm"), 'y'); }
                if (fioilu > 1) { i.txt(string.Concat("bitola de fios da iluminacao ", fioilu, "  mm"), 'y'); }
                if (fiob > 1) { i.txt(string.Concat("bitola de fios do banheiro", fiob, "  mm"), 'y'); }
                if (fioc > 1) { i.txt(string.Concat("bitola de fios da cozinha", fioc, "  mm"), 'y'); }
                if (fioe > 1) { i.txt(string.Concat("bitola de fios do escritorio ", fioe, "  mm"), 'y'); }
                if (fiofer > 1) { i.txt(string.Concat("bitola das ferramentas ", fiofer, "  mm"), 'y'); }
                if (fiol > 1) { i.txt(string.Concat("bitola de fios da lavadeiria", fiol, "  mm"), 'y'); }
                if (fioquim > 1) { i.txt(string.Concat("bitola de fios do quintal", fioquim, "  mm"), 'y'); }
                if (fioq > 1) { i.txt(string.Concat("bitola de fios dos quartos ", fioq, "  mm"), 'y'); }
                if (fios > 1) { i.txt(string.Concat("bitola de fios da sala ", fios, "  mm"), 'y'); }

                if (fiop > 1) { i.txt(string.Concat("bitola de fios primcipal ", fiop, "  mm"), 'g'); }


                break;
        case 't':
            



                Console.WriteLine("-----------------------------------------------------");
                i.txt(" padrao trifasico ", 'm');
                Console.WriteLine("-----------------------------------------------------");
                // Console.WriteLine("potencia da sala: {0}"  , salares +   "  watts " );
                //i.txt(string.Concat("potencia da sala: ", salares + "  watts "), 'r');
                // Console.WriteLine($"grana   {biel.grana}" + $"nome   {biel.nome}" + $"car   {biel.car}");





                if (salares > 1) { i.txt(string.Concat("potencia da sala:  ", salares, "  watts"), 'y'); }
                if (quartores > 1) { i.txt(string.Concat("potencia dos quartosa:  ", quartores, "  watts"), 'y'); }
                if (quintalres > 1) { i.txt(string.Concat("potencia do quintal:  ", quintalres, "  watts"), 'y'); }
                if (lavadeiriares > 1) { i.txt(string.Concat("potencia da lavadeiria:  ", lavadeiriares, "  watts"), 'y'); }
                if (ferramentasres > 1) { i.txt(string.Concat("potencia das ferramantas:  ", ferramentasres, "  watts"), 'y'); }
                if (escritoriores > 1) { i.txt(string.Concat("potencia do escritorio:  ", escritoriores, "  watts"), 'y'); }
                if (cozinhares > 1) { i.txt(string.Concat("potencia da cozinha:  ", cozinhares, "  watts"), 'y'); }
                if (banheiores > 1) { i.txt(string.Concat("potencia do banheiro:  ", banheiores, "  watts"), 'y'); }
                if (outrosres > 1) { i.txt(string.Concat("potencia de outros:  ", outrosres, "  watts"), 'y'); }
                if (iluminares > 1) { i.txt(string.Concat("potencia da  iluminacao:  ", iluminares, "  watts"), 'y'); }

                
                if (res > 1) { i.txt(string.Concat("potencia total :  ", res, "  watts"), 'g'); }



                

                Console.WriteLine("-----------------------------------------------------");

                i.txt("dinjuntores:", 'm');


                Console.WriteLine("-----------------------------------------------------");


                if (djo > 1) { i.txt(string.Concat("1 dinjunto de outros  ", djo, "  anperes"), 'y'); }
                if (djb > 1) { i.txt(string.Concat(" dinjunto do banheiro  ", djb, "  anperes"), 'y'); }
                if (djc > 1) { i.txt(string.Concat("1 dinjunto da cosinha  ", djc, "  anperes"), 'y'); }
                if (dje > 1) { i.txt(string.Concat("1 dinjunto do escritorio ", dje, "  anperes"), 'y'); }
                if (djl > 1) { i.txt(string.Concat("1 dinjunto da lavadeiria  ", djl, "  anperes"), 'y'); }
                if (djfer > 1) { i.txt(string.Concat("1 dinjunto de ferramentas ", djqui, "  anperes"), 'y'); }
                if (djqui > 1) { i.txt(string.Concat("1 dinjunto do quintal  ", djqui, "  anperes"), 'y'); }
                if (djq > 1) { i.txt(string.Concat(" dinjunto do quarto  ", djq, "  anperes"), 'y'); }
                if (djs > 1) { i.txt(string.Concat("1 dinjunto sala  ", djs, "  anperes"), 'y'); }
                if (djilum > 1) { i.txt(string.Concat("1 dinjunto iluminacao  ", djilum, "  anperes"), 'y'); }

                if (djprim > 1) { i.txt(string.Concat("1 dinjunto primcipal  ", djprim, "  anperes"), 'g'); }

                
                Console.WriteLine("-----------------------------------------------------");
                i.txt("fios:", 'm');
                Console.WriteLine("-----------------------------------------------------");



                if (fioo > 1) { i.txt(string.Concat("bitola de fios de outros ", fioo, "  mm"), 'y'); }
                if (fioilu > 1) { i.txt(string.Concat("bitola de fios da iluminacao ", fioilu, "  mm"), 'y'); }
                if (fiob > 1) { i.txt(string.Concat("bitola de fios do banheiro", fiob, "  mm"), 'y'); }
                if (fioc > 1) { i.txt(string.Concat("bitola de fios da cozinha", fioc, "  mm"), 'y'); }
                if (fioe > 1) { i.txt(string.Concat("bitola de fios do escritorio ", fioe, "  mm"), 'y'); }
                if (fiofer > 1) { i.txt(string.Concat("bitola das ferramentas ", fiofer, "  mm"), 'y'); }
                if (fiol > 1) { i.txt(string.Concat("bitola de fios da lavadeiria", fiol, "  mm"), 'y'); }
                if (fioquim > 1) { i.txt(string.Concat("bitola de fios do quintal", fioquim, "  mm"), 'y'); }
                if (fioq > 1) { i.txt(string.Concat("bitola de fios dos quartos ", fioq, "  mm"), 'y'); }
                if (fios > 1) { i.txt(string.Concat("bitola de fios da sala ", fios, "  mm"), 'y'); }

                if (fiop > 1) { i.txt(string.Concat("bitola de fios primcipal ", fiop, "  mm"), 'g'); }



                break;



    
        }

        Console.WriteLine(salares);
        Console.WriteLine(res);



         void imprimir()
        {
            switch (padrao)
            {
                case 'm':


                    i.reg();

                    i.txt("padrao monofasico", 'm');

                    // Console.WriteLine("potencia da sala: {0}"  , salares +   "  watts " );
                    //i.txt(string.Concat("potencia da sala: ", salares + "  watts "), 'r');
                    // Console.WriteLine($"grana   {biel.grana}" + $"nome   {biel.nome}" + $"car   {biel.car}");





                    if (salares > 1) { i.txt(string.Concat("potencia da sala:  ", salares, "  watts"), 'y'); }
                    if (quartores > 1) { i.txt(string.Concat("potencia dos quartosa:  ", quartores, "  watts"), 'y'); }
                    if (quintalres > 1) { i.txt(string.Concat("potencia do quintal:  ", quintalres, "  watts"), 'y'); }




                    Console.WriteLine("potencia da lavadeiria:   ", lavadeiriares, "  watts");
                    Console.WriteLine("potencia das ferramentas:   ", ferramentasres, "  watts");
                    Console.WriteLine("potencia do escritorio:   ", escritoriores, "  watts");
                    Console.WriteLine("potencia da cozinha:   ", cozinhares, "  watts");
                    Console.WriteLine("potencia do banheiro:   ", banheiores, "  watts");
                    Console.WriteLine("potencia de outros:   ", outrosres, "  watts");
                    Console.WriteLine("potencia da  iluminacao:   ", iluminares, "  watts");
                    Console.WriteLine("potencia total do padrao:  ", res, "  watts");
                    Console.WriteLine("-----------------------------------------------------");




                    Console.WriteLine("dinjuntores:");

                    Console.WriteLine("1 dinjunto primcipal:  ", djprim, "  amperes");
                    Console.WriteLine("1 dinjunto iluminacao:  ", djilum, "  ampres");
                    Console.WriteLine("1 dinjunto da sala:   ", djs, "  amperes");
                    Console.WriteLine("1 dinjunto do quartos:   ", djq, "  amperes");
                    Console.WriteLine("1 dinjunto do quintal:   ", djqui, "  amperes");
                    Console.WriteLine("1 dinjunto das ferramentas:   ", djfer, "  amperes");
                    Console.WriteLine("1 dinjunto da lavadeiria:   ", djl, "  amperes");
                    Console.WriteLine("1 dinjunto do escritorio:   ", dje, "  amperes");
                    Console.WriteLine("1 dinjunto da cozinha:   ", djc, "  amperes");
                    Console.WriteLine("1 dinjunto do banheiro:   ", djb, "  amperes");
                    Console.WriteLine("1 dinjunto de outros:   ", djo, "  amperes");

                    Console.WriteLine("-----------------------------------------------------");

                    Console.WriteLine("fios:");


                    Console.WriteLine("bitola de fios primcipal :  ", fiop, "  mm");

                    Console.WriteLine("bitola de fios da sala:  ", fios, "  mm");
                    Console.WriteLine("bitola de fios dos quartos:  ", fioq, "  mm");
                    Console.WriteLine("bitola de fios do quintal:  ", fioquim, "  mm");
                    Console.WriteLine("bitola de fios da lavadeiria:  ", fiol, "  mm");
                    Console.WriteLine("bitola de fios das ferramentas:  ", fiofer, "  mm");
                    Console.WriteLine("bitola de fios do escritorio:  ", fios, "  mm");
                    Console.WriteLine("bitola de fios da cozinha:  ", fioc, "  mm");
                    Console.WriteLine("bitola de fios d o banheiro:  ", fiob, "  mm");
                    Console.WriteLine("bitola de fios da iluminacao:  ", fioilu, "  mm");
                    Console.WriteLine("bitola de fios de outros:  ", fioo, "  mm");

                    break;
                case 'b':
                    Console.WriteLine("padrao bifasico");

                    Console.WriteLine("potencia da sala:   ", salares, "  watts");
                    Console.WriteLine("potencia dos quartos:   ", quartores, "  watts");
                    Console.WriteLine("potencia do quintal:   ", quintalres, "  watts");
                    Console.WriteLine("potencia da lavadeiria:   ", lavadeiriares, "  watts");
                    Console.WriteLine("potencia das ferramentas:   ", ferramentasres, "  watts");
                    Console.WriteLine("potencia do escritorio:   ", escritoriores, "  watts");
                    Console.WriteLine("potencia da cozinha:   ", cozinhares, "  watts");
                    Console.WriteLine("potencia do banheiro:   ", banheiores, "  watts");
                    Console.WriteLine("potencia de outros:   ", outrosres, "  watts");
                    Console.WriteLine("potencia da  iluminacao:   ", iluminares, "  watts");
                    Console.WriteLine("potencia total do padrao:  ", res, "  watts");
                    Console.WriteLine("-----------------------------------------------------");



                    Console.WriteLine("dinjuntores:");

                    Console.WriteLine("1 dinjunto primcipal:  ", djprim, "  amperes");
                    Console.WriteLine("1 dinjunto iluminacao:  ", djilum, "  ampres");
                    Console.WriteLine("1 dinjunto da sala:   ", djs, "  amperes");
                    Console.WriteLine("1 dinjunto do quartos:   ", djq, "  amperes");
                    Console.WriteLine("1 dinjunto do quintal:   ", djqui, "  amperes");
                    Console.WriteLine("1 dinjunto das ferramentas:   ", djfer, "  amperes");
                    Console.WriteLine("1 dinjunto da lavadeiria:   ", djl, "  amperes");
                    Console.WriteLine("1 dinjunto do escritorio:   ", dje, "  amperes");
                    Console.WriteLine("1 dinjunto da cozinha:   ", djc, "  amperes");
                    Console.WriteLine("1 dinjunto do banheiro:   ", djb, "  amperes");
                    Console.WriteLine("1 dinjunto de outros:   ", djo, "  amperes");

                    Console.WriteLine("-----------------------------------------------------");

                    Console.WriteLine("fios:");


                    Console.WriteLine("bitola de fios primcipal:  ", fiop, "  mm");

                    Console.WriteLine("bitola de fios da sala:  ", fios, "  mm");
                    Console.WriteLine("bitola de fios dos quartos:  ", fioq, "  mm");
                    Console.WriteLine("bitola de fios do quintal:  ", fioquim, "  mm");
                    Console.WriteLine("bitola de fios da lavadeiria:  ", fiol, "  mm");
                    Console.WriteLine("bitola de fios das ferramentas:  ", fiofer, "  mm");
                    Console.WriteLine("bitola de fios do escritorio:  ", fios, "  mm");
                    Console.WriteLine("bitola de fios da cozinha:  ", fioc, "  mm");
                    Console.WriteLine("bitola de fios d o banheiro:  ", fiob, "  mm");
                    Console.WriteLine("bitola de fios da iluminacao:  ", fioilu, "  mm");
                    Console.WriteLine("bitola de fios de outros:  ", fioo, "  mm");

                    break;
                case 't':
                    Console.WriteLine("padrao trifasico");

                    Console.WriteLine("potencia da sala:   ", salares, "  watts");
                    Console.WriteLine("potencia dos quartos:   ", quartores, "  watts");
                    Console.WriteLine("potencia do quintal:   ", quintalres, "  watts");
                    Console.WriteLine("potencia da lavadeiria:   ", lavadeiriares, "  watts");
                    Console.WriteLine("potencia das ferramentas:   ", ferramentasres, "  watts");
                    Console.WriteLine("potencia do escritorio:   ", escritoriores, "  watts");
                    Console.WriteLine("potencia da cozinha:   ", cozinhares, "  watts");
                    Console.WriteLine("potencia do banheiro:   ", banheiores, "  watts");
                    Console.WriteLine("potencia de outros:   ", outrosres, "  watts");
                    Console.WriteLine("potencia da  iluminacao:   ", iluminares, "  watts");
                    Console.WriteLine("potencia total do padrao:  ", res, "  watts");
                    Console.WriteLine("-----------------------------------------------------");



                    Console.WriteLine("dinjuntores:");

                    Console.WriteLine("1 dinjunto primcipal:  ", djprim, "  amperes");
                    Console.WriteLine("1 dinjunto iluminacao:  ", djilum, "  ampres");
                    Console.WriteLine("1 dinjunto da sala:   ", djs, "  amperes");
                    Console.WriteLine("1 dinjunto do quartos:   ", djq, "  amperes");
                    Console.WriteLine("1 dinjunto do quintal:   ", djqui, "  amperes");
                    Console.WriteLine("1 dinjunto das ferramentas:   ", djfer, "  amperes");
                    Console.WriteLine("1 dinjunto da lavadeiria:   ", djl, "  amperes");
                    Console.WriteLine("1 dinjunto do escritorio:   ", dje, "  amperes");
                    Console.WriteLine("1 dinjunto da cozinha:   ", djc, "  amperes");
                    Console.WriteLine("1 dinjunto do banheiro:   ", djb, "  amperes");
                    Console.WriteLine("1 dinjunto de outros:   ", djo, "  amperes");

                    Console.WriteLine("-----------------------------------------------------");

                    Console.WriteLine("fios:");


                    Console.WriteLine("bitola de fios primcipal:  ", fiop, "  mm");
                    Console.WriteLine("bitola de fios da sala:  ", fios, "  mm");
                    Console.WriteLine("bitola de fios dos quartos:  ", fioq, "  mm");
                    Console.WriteLine("bitola de fios do quintal:  ", fioquim, "  mm");
                    Console.WriteLine("bitola de fios da lavadeiria:  ", fiol, "  mm");
                    Console.WriteLine("bitola de fios das ferramentas:  ", fiofer, "  mm");
                    Console.WriteLine("bitola de fios do escritorio:  ", fios, "  mm");
                    Console.WriteLine("bitola de fios da cozinha:  ", fioc, "  mm");
                    Console.WriteLine("bitola de fios d o banheiro:  ", fiob, "  mm");
                    Console.WriteLine("bitola de fios da iluminacao:  ", fioilu, "  mm");
                    Console.WriteLine("bitola de fios de outros:  ", fioo, "  mm");
                    break;




            }
        }

    }
}
interface i
{



    public static void cor(string txt, ConsoleColor cor)
    {
        Console.ForegroundColor = cor;

        Console.WriteLine(txt);
        Console.ResetColor();
    }
    public static void reg()
    {
        string m = "====================================================================";
        cor(m, ConsoleColor.Red);
        m = "===================================================";
        cor(m, ConsoleColor.Yellow);
        m = "==================================";
        cor(m, ConsoleColor.Green);
    }

    public static void txt(string m, char c)
    {


        if (c == 'r')
        {
            cor(m, ConsoleColor.Red);
        }
        else if (c == 'b')
        {
            cor(m, ConsoleColor.Blue);
        }
        else if (c == 'y')
        {
            cor(m, ConsoleColor.Yellow);
        }
        else if (c == 'g')
        {
            cor(m, ConsoleColor.Green);
        }
        else if (c == 'w') { cor(m, ConsoleColor.White); }
        else if (c == 'm') { cor(m, ConsoleColor.Magenta); }

         
  



    }
}