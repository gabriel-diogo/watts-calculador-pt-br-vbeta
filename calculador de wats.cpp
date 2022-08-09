#include <bits/stdc++.h>//all



using namespace std;






float fios=0,fioq=0,fioc=0,fiob=0,fioquim=0,fiol=0,fioe,fiolav=0,fiofer=0,fioo=0,fioilu=0;float fiop=0;
int quartores=0,salares=0,cozinhares=0,banheiores=0,quintalres=0,limpezares=0,escritoriores=0,lavadeiriares=0,ferramentasres=0,outrosres=0,iluminares=0;
int djq=0,djs=0,djc=0,djb=0,djqui=0,djl=0,dje=0,djlv=0,djfer=0,djo=0,djilum=0;int djprim=0;
char padrao; int res=0;

int imprimir();
    

int main(){
                                                    
    
    
    char perg; char pg;  int opc,opc1;


    string tvsc,lampadasc,arsc,sonsc,vsalac,dvdsc,tvqc,lamqc,arqc,sonqc;string batcs,liqcs,encs,asps,imps,cops,les,ares,lavs,fers,secls,lavses;
    string comqc,chbc,secc,chapc,aquc,lambc,lquimc,aquaqs,churrs,lcozc; string cafecs,gelcs,fogcs,miccs,forcs,torcs,trns,enbcs,espcs,arcs;
    string corts,aspc,boms,furs,maks,sers,ferfs,telc,slids,aquqs,copfs,lss;string opcc,opcc1;
    
    
    int encres,aspres,impres,copres,leres,areres; int churrres=0,trnres=0,lamres=0,watts=0;
    int tvs1,arres,sonsres,tvqres,lamqres,arqres,sonqres,comqres,tvsres,lampadasres;  
    int chbres,secres,chapres,aqures,lambres,lquimres,aquqres,lcozres; 
    int vsalares,dvdsres,cafecres,gelcres,fogcres,miccres,forcres,torcres,enbcres,espcres,arcres,batcres,liqcres;
    int lavres,ferres,seclres,lavseres,cortres,bomres,furres,makres,serres,copfres,ferfres,telres,slidres;
    
    
    int ars,sons,tvq,lamq,arq,sonq,comqtvs,lampadas,tvs; int churr=0,trn=0,lam=0;
    int chb,sec,chap,aqu,lamb,comq,lquim,aquq,lcoz; int enc,asp,imp,cop,le,are;
    int ars1,sons1,tvq1,lamq1,arq1,sonq1,comq1,lampadas1; int enc1,asp1,imp1,cop1,le1,are1;
    int chb1,sec1,chap1,aqu1,lamb1,lquim1,aquq1,lcoz1; int churr1=0,trn1=0,ls1=0;
    int vsala,dvds,cafec,gelc,fogc,micc,forc,torc,enbc,espc,arc,batc,liqc;
    int vsala1,dvds1,cafec1,gelc1,fogc1,micc1,forc1,torc1,enbc1,espc1,arc1,batc1,liqc1;
    int lav,fer,secl,lavse,cort,bom,fur,mak,ser,copf,ferf,tel,slid;
    int lav1,fer1,secl1,lavse1,cort1,bom1,fur1,mak1,ser1,copf1,ferf1,tel1,slid1;
    
    
    


    ars=0;sons=0;tvq=0;lamq=0;arq=0;sonq=0;comqtvs=0;lampadas=0;tvs=0, chb=0,sec=0,chap=0,aqu=0,lamb=0,comq=0,lquim=0,aquq=0,lcoz=0 ; 
    ars1=0;sons1=0;tvq1=0;lamq1=0;arq1=0;sonq1=0;comq1=0;lampadas1=0;tvs1=0, chb1=0,sec1=0,chap1=0,aqu1=0,lamb1=0,lquim1=0,aquq1=0,lcoz1=0; 
    arres=0,sonsres=0,tvqres=0,lamqres=0,arqres=0,sonqres=0,tvsres=0,lampadasres=0;lambres=0,comqres=0,lquimres=0,aquqres=0,lcozres=0;
    enc1=0,asp1=0,imp1=0,cop1=0,le1=0,are1=0;encres=0,aspres=0,impres=0,copres=0,leres=0,areres=0;
    vsala=0;dvds=0;cafec=0;gelc=0;fogc=0;micc=0;forc=0;torc=0;enbc=0;espc=0;arc=0;batc=0;liqc=0;chbres=0,secres=0,chapres=0,aqures=0;
    vsala1=0;dvds1=0;cafec1=0;gelc1=0;fogc1=0;micc1=0;forc1=0;torc1=0;enbc1=0;espc1=0;arc1=0;batc1=0;liqc1=0;enc=0,asp=0,imp=0,cop=0,le=0,are=0;
    vsalares=0;dvdsres=0;cafecres=0;gelcres=0;fogcres=0;miccres=0;forcres=0;torcres=0;enbcres=0;espcres=0;arcres=0;batcres=0;liqcres=0;
    lav=0,fer=0,secl=0,lavse=0,cort=0,bom=0,fur=0,mak=0,ser=0,copf=0,ferf=0,tel=0,slid=0;
    lav1=0,fer1=0,secl1=0,lavse1=0,cort1=0,bom1=0,fur1=0,mak1=0,ser1=0,copf1=0,ferf1=0,tel1=0,slid1=0;
    lavres=0,ferres=0,seclres=0,lavseres=0,cortres=0,bomres=0,furres=0,makres=0,serres=0,copfres=0,ferfres=0,telres=0,slidres=0;

    

    

   
  
    cout<<"deseja calcular a pontencia de aparelhos (s/n)"<<endl;
    cin>>perg;
   
    
    while((perg=='s')||(perg=='S')){
        
            
        
        cout<<"digite a parte da casa que deseja calcular"<<endl;


        cout<<"1-sala"<<endl;
        cout<<"2-quartos"<<endl;
        cout<<"3-banheiro"<<endl;
        cout<<"4-quintal"<<endl;
        cout<<"5-cozinha"<<endl;
        cout<<"6-equipamento de limpeza"<<endl;
        cout<<"7-escritorio"<<endl;
        cout<<"8-lavandeiria"<<endl;
        cout<<"9-ferramentas"<<endl;
        cout<<"10-outros"<<endl;
        

        cin>>opcc1;

        if (opcc1=="1"){opc1=1;}
        else if (opcc1=="2") {opc1=2;}
        else if (opcc1=="3") {opc1=3;}
        else if (opcc1=="4") {opc1=4;}
        else if (opcc1=="5") {opc1=5;}
        else if (opcc1=="6") {opc1=6;}
        else if (opcc1=="7") {opc1=7;}
        else if (opcc1=="8") {opc1=8;}
        else if (opcc1=="9") {opc1=9;}
        else if (opcc1=="10") {opc1=10;}
        else{cout<<"opicao invalida"<<endl;break;}
        
       
        switch(opc1){
            case 1:
                system("cls");
                cout<<"1-tv"<<endl;
                cout<<"2-lampada"<<endl;
                cout<<"3-ar condicionado"<<endl;
                cout<<"4-som"<<endl;
                cout<<"5-videogame"<<endl;
                cout<<"6-dvd"<<endl;

              
                  

                cin>>opcc;
                if (opcc=="1"){opc=1; }
                else if (opcc=="2"){opc=2; }
                else if (opcc=="3"){opc=3; }
                else if (opcc=="4"){opc=4; }
                else if (opcc=="5"){opc=5; }
                else if (opcc=="6"){opc=6; }
                else{cout<<"opicao invalida"<<endl;break;}    
               
                
                //if (opc >6 ){cout<<"opicao invalida"<<endl;break;}

                switch(opc){
                    case 1:
                        system("cls");
                        cout<<"modelo da tv "<<endl;
                        cout<<"1-led"<<endl;
                        cout<<"2-smart"<<endl;
                        cout<<"3-plasma"<<endl;
                        cout<<"4-LCD"<<endl;
                        cout<<"5-tubo"<<endl;
                        cout<<"6-de 50 polegadas a cima"<<endl;
                                    
                        
                        cin>>tvsc;

                       // try{
                       //if ((tvs == 1 )||(tvs == 2)||(tvs == 3)||(tvs == 4)||(tvs == 5)||(tvs == 6)){
                       //cout<<"opicao invalida"<<endl;break;
                       //}else{cout<<"opicao invalida"<<endl;break; }
                           


                       //}catch(const char* msg){ cout<<"Erro: "<<msg<<endl; }
               
                        
                        if(tvsc=="1"){tvs=200;
                        }else if(tvsc=="2"){tvs=320; 
                        }else if(tvsc=="3"){tvs=320; 
                        }else if(tvsc=="4"){tvs=320;     
                        }else if(tvsc=="5"){tvs=300;
                        }else if(tvsc=="6"){tvs=400;  }
                        else{cout<<"opcao invalida"<<endl;break;}   
                        cout<<"quantidade de tv"<<endl;
                        cin>>tvs1;
                        // tvsres=tvs*tvs1;
                        
                        break;
                    case 2:
                        system("cls");
                        cout<<"modelo da lampada"<<endl;
                        cout<<"1-led"<<endl;
                        cout<<"2-encadecete amarela"<<endl;
                        cout<<"3-fluorescente"<<endl;
                        cout<<"4-lustre"<<endl;
                        cout<<"5-tubular"<<endl;

                        cin>>lampadasc;
                        
                        

                        

                        if(lampadasc=="1"){lampadas=10;
                        }else if(lampadasc=="2"){lampadas=100;
                        }else if(lampadasc=="3"){lampadas=23;
                        }else if(lampadasc=="4"){lampadas=100;
                        }else if(lampadasc=="5"){lampadas=40;
                        }else{cout<<"opicao invalida"<<endl;break;}

                        cout<<"quantidade de lampada"<<endl;
                        cin>>lampadas1;
                        // lampadasres=lampadas*lampadas1;
                        break;
                    case 3:
                        system("cls");
                        cout<<"modelo do ar condicionado"<<endl;
                        cout<<"1-7500 btu"<<endl;
                        cout<<"2-12000 btu"<<endl;
                        cout<<"3-18000 btu"<<endl;
                        cout<<"4-10000 btu"<<endl;
                        cout<<"5-15000 btu"<<endl;
                        cout<<"6-ventilador"<<endl;
                        cout<<"7-ventilador de teto"<<endl;
                        
                        cin>>arsc;
                        
                        

                     
                        

                        if(arsc=="1"){ars=1000;
                        }else if(arsc=="2"){ars=1450;
                        }else if(arsc=="3"){ars=2100;
                        }else if(arsc=="4"){ars=1350;
                        }else if(arsc=="5"){ars=2500;
                        }else if(arsc=="6"){ars=100;
                        }else if(arsc=="7"){ars=120;
                        }else{cout<<"opicaoinvalida"<<endl;break;}

                        cout<<"quantidade de ar condicionado"<<endl;
                        cin>>ars1;
                        // arres=ars*ars1;
                        
                        break;
                    case 4:
                        system("cls");
                        cout<<"modelo do som"<<endl;
                        cout<<"1-som mini-system"<<endl;
                        cout<<"2-som 3em1"<<endl;
                        cout<<"3-som pesado"<<endl;

                        cin>>sonsc;
                        
                        
                        if(sonsc=="1"){sons=100;
                        }else if(sonsc=="2"){sons=500;
                        }else if(sonsc=="3"){sons=1500;
                        }else{cout<<"opicao invalida"<<endl;break;}

                        cout<<"quantidade de som"<<endl;
                        cin>>sons1;
                        //sonsres=sons*sons1;    
                        break;
                    case 5:
                        system("cls");
                        cout<<"modelo do videogame"<<endl;
                        cout<<"1-playstation"<<endl;
                        cout<<"2-xbox"<<endl;
                        cout<<"3-wii"<<endl;
                        cout<<"4-nintendo"<<endl;
                        cin>>vsalac;
                       
                        
                        if(vsalac=="1"){vsala=200;
                        }else if(vsalac=="2"){vsala=200;                    
                        }else if(vsalac=="3"){ vsala=100;               
                        }else if(vsalac=="4"){vsala=50; 
                        }else{cout<<"opicaoinvalida"<<endl;break;} 

                        cout<<"quantidade de videogame"<<endl;
                        cin>>vsala1;                 
                        //vsalares=vsala*vsala1;
                        break;
                    case 6: 

                        system("cls");
                        cout<<"modelo do dvd"<<endl;
                        cout<<"1-dvd"<<endl;
                        cout<<"2-dvd-home theater -simples"<<endl;
                        cout<<"3-dvd-home theater -completo"<<endl;

                        cin>>dvdsc;
                       

                       
                        if(dvdsc=="1"){dvds=100;
                        }else if(dvdsc=="2"){dvds=500;    
                        }else if(dvdsc=="3"){dvds=1000;
                        }else{cout<<"opicaoinvalida"<<endl;break;}

                        cout<<"quantidade de dvd"<<endl;
                        cin>>dvds1;

                        //dvdsres=dvds*dvds1;
                                        
                    break;
                            
                }
             

                break;

            case 2:
                system("cls");
                cout<<"1-tv"<<endl;
                cout<<"2-lampada"<<endl;
                cout<<"3-ar condicionado"<<endl;
                cout<<"4-som"<<endl;
                cout<<"5-coputador"<<endl;

                cin>>opcc;

                if (opcc=="1"){opc=1; }
                else if (opcc=="2"){opc=2; }
                else if (opcc=="3"){opc=3; }
                else if (opcc=="4"){opc=4; }
                else if (opcc=="5"){opc=5; }
                else{cout<<"opicao invalida"<<endl;break;}  
               

                switch(opc){
                    case 1:
                        system("cls");
                        cout<<"modelo da tv "<<endl;
                        cout<<"1-led"<<endl;
                        cout<<"2-smart"<<endl;
                        cout<<"3-plasma"<<endl;
                        cout<<"4-LCD"<<endl;
                        cout<<"5-tubo"<<endl;
                        cout<<"6-de 50 polegadas a cima"<<endl;

                        cin>>tvqc;
                        

                        if(tvqc=="1"){tvq=200;
                        }else if(tvqc=="2"){tvq=200;
                        }else if(tvqc=="3"){tvq=320;
                        }else if(tvqc=="4"){tvq=200;                
                        }else if(tvqc=="5"){tvq=300;            
                        }else if(tvqc=="6"){tvq=400; 
                        }else{cout<<"opicao invalida"<<endl;break;} 

                        cout<<"quantidade de tv"<<endl;
                        cin>>tvq1; 

                        //tvqres=tvq*tvq1;
                        break;

                    case 2:
                        system("cls");
                        cout<<"modelo da lampada"<<endl;
                        cout<<"1-led"<<endl;
                        cout<<"2-encadecete amarela"<<endl;
                        cout<<"3-fluorescente"<<endl;
                        cout<<"4-lustre"<<endl;
                        cout<<"5-tubular"<<endl;
                        cin>>lamqc;
                      
                        

                        if(lamqc=="1"){lamq=10;
                        }else if(lamqc=="2"){ lamq=100;               
                        }else if(lamqc=="3"){ lamq=23;          
                        }else if(lamqc=="4"){ lamq=100;               
                        }else if(lamqc=="5"){lamq=40; 
                        }else{cout<<"opicao invalida"<<endl;break;}  

                        cout<<"quantidade de lampada"<<endl;
                        cin>>lamq1;           
                        //lamqres=lamq*lamq1;
                        break;
                    case 3:
                        system("cls");
                        cout<<"modelo do ar condicionado"<<endl;
                        cout<<"1-7500 btu"<<endl;
                        cout<<"2-12000 btu"<<endl;
                        cout<<"3-18000 btu"<<endl;
                        cout<<"4-10000 btu"<<endl;
                        cout<<"5-15000 btu"<<endl;
                        cout<<"6-ventilador"<<endl;
                        
                        cin>>arqc;
                       
                        

                        if(arqc=="1"){arq=1000;
                        }else if(arqc=="2"){ arq=1450;               
                        }else if(arqc=="3"){  arq=2100;          
                        }else if(arqc=="4"){arq=1350;                
                        }else if(arqc=="5"){ arq=2000;           
                        }else if(arqc=="6"){ arq=100; 
                        }else{cout<<"opicao invalida"<<endl;break;} 

                        cout<<"quantidade de ar condicionado"<<endl;
                        cin>>arq1;           
                        //arqres=arq*arq1;
                        break;            
             
                    case 4:
                        system("cls");
                        cout<<"modelo do som"<<endl;
                        cout<<"1-som mini-system"<<endl;
                        cout<<"2-som 3em1"<<endl;
                        cout<<"3-som pesado"<<endl;
                        
                        cin>>sonqc;
                        

                        if(sonqc=="1"){sonq=100;
                        }else if(sonqc=="2"){sonq=500;                
                        }else if(sonqc=="3"){sonq=1500;            
                        }else{cout<<"opicao invalida"<<endl;break;} 

                        cout<<"quantidade de som"<<endl;
                        cin>>sonq1;
                        //sonqres=sonq*sonq1;
                        break;
                    case 5:
                        system("cls");
                        cout<<"modelo do computador"<<endl;
                        cout<<"1-computador"<<endl;
                        cout<<"2-pc gamer"<<endl;
                        cout<<"3-pc escritorio"<<endl;
                        cout<<"4-notebook"<<endl;
                        cout<<"5-notebook gamer"<<endl;
                        cout<<"6-escritorio"<<endl;

                        cin>>comqc;
                        

                        if(comqc=="1"){comq=300;
                        }else if(comqc=="2"){ comq=500;               
                        }else if(comqc=="3"){ comq=400;          
                        }else if(comqc=="4"){comq=100;                
                        }else if(comqc=="5"){ comq=200;           
                        }else if(comqc=="6"){comq=500;                
                        }else{cout<<"opicao invalida"<<endl;break;} 

                        cout<<"quantidade de computador"<<endl;
                        cin>>comq1;
                        //comqres=comq*comq1;
                        break;

                                
                    }
                        
                       
                break;
            case 3:
                system("cls");
                cout<<"1-chuveiro"<<endl;
                cout<<"2-secador de cabelo"<<endl;
                cout<<"3-chapa de cabelo"<<endl;
                cout<<"4-aquecedor de agua"<<endl;
                cout<<"5-lampada"<<endl;

                cin>>opcc;

                if (opcc=="1"){opc=1; }
                else if (opcc=="2"){opc=2; }
                else if (opcc=="3"){opc=3; }
                else if (opcc=="4"){opc=4; }
                else if (opcc=="5"){opc=5; }
                else{cout<<"opicao invalida"<<endl;break;}  
                

                switch(opc){
                    case 1:
                     system("cls");
                     cout<<"modelo do chuveiro"<<endl;
                     cout<<"1-chuveiro 3 teperaturas"<<endl;
                     cout<<"2-chuveiro 4 teperaturas"<<endl;
                     cout<<"3-chuveiro luxo"<<endl;

                     cin>>chbc;
                     

                     if(chbc=="1"){chb=5500;
                     }else if(chbc=="2"){chb=6500;
                     }else if(chbc=="3"){chb=7500;                    
                     }else{cout<<"opicao invalida"<<endl;break;} 

                     cout<<"quantidade de chuveiro"<<endl;
                     cin>>chb1;
                     //chbres=chb*chb1;
                     break;

                    case 2:
                        system("cls");
                        cout<<"modelo do secador de cabelo"<<endl;
                        cout<<"1-secador de cabelo simples"<<endl;
                        cout<<"2-secador de cabelo medio"<<endl;
                        cout<<"3-secador de cabelo proficional"<<endl;

                        cin>>secc;
                        

                        if(secc=="1"){sec=1000;
                        }else if(secc=="2"){sec=1500;                
                        }else if(secc=="3"){sec=2000;            
                        }else{cout<<"opicao invalida"<<endl;break;} 


                        cout<<"quantidade de secador de cabelo"<<endl;
                        cin>>sec1;          
                        // secres=sec*sec1;
                        break;
                    case 3:
                        system("cls");
                        cout<<"modelo da chapa de cabelo"<<endl;
                        cout<<"1-chapa de cabelo simples"<<endl;
                        cout<<"2-chapa de cabelo proficional"<<endl;

                        cin>>chapc;
                        
                        if(chapc=="1"){chap=200;
                        }else if(chapc=="2"){chap=500;
                        }else{cout<<"opicao invalida"<<endl;break;} 

                        cout<<"quantidade de chapa de cabelo"<<endl;
                        cin>>chap1;
                        // chapres=chap*chap1;
                        break;
                    case 4:
                    system("cls");
                      cout<<"tipo do aquecedor de agua"<<endl;
                      cout<<"1-aquecedor de agua"<<endl;
                      cout<<"2-aquecedor de agua de banheira 127 volts"<<endl;
                      cout<<"3-aquecedor de agua de banheira 220 volts"<<endl;
                      cout<<"4-aquecedor de agua de pasagem"<<endl;

                      cin>>aquc;
                      

                      if(aquc=="1"){aqu=2000;
                      }else if(aquc=="2"){aqu=5000;      
                      }else if(aquc=="3"){aqu=8000;  
                      }else if(aquc=="4"){aqu=6000;      
                      }else{cout<<"opicao invalida"<<endl;break;}

                      cout<<"quantidade de aquecedor de agua"<<endl;
                      cin>>aqu1;
                      //aqures=aqu*aqu1;
                      break;
                    case 5:
                        system("cls");
                        cout<<"modelo da lampada"<<endl;
                        cout<<"1-lampada led"<<endl;
                        cout<<"2-lampada incandescente"<<endl;
                        cout<<"3-lampada fluorescente"<<endl;
                        cout<<"4-lampada tubular"<<endl;
                        cout<<"5-lustre"<<endl;

                        cin>>lambc;
                        

                        if(lambc=="1"){lamb=10;
                        }else if(lambc=="2"){lamb=100;
                        }else if(lambc=="3"){lamb=23;
                        }else if(lambc=="4"){lamb=40;    
                        }else if(lambc=="5"){lamb=100;
                        }else{cout<<"opicao invalida"<<endl;break;} 

                        cout<<"quantidade de lampada"<<endl;
                        cin>>lamb1;
                        //lambres=lamb*lamb1;
                        break;
                            
                    }
                       
                break;
                    
            case 4:
                system("cls");
                cout<<"1-lampadas"<<endl;
                cout<<"2-aquecedores de de picina "<<endl;
                cout<<"3-churrasqueira elerica"<<endl;
                            

                cin>>opcc;

                if (opcc=="1"){opc=1; }
                else if (opcc=="2"){opc=2; }
                else if (opcc=="3"){opc=3; }
                else{cout<<"opicao invalida"<<endl;break;}
                


                switch(opc){
                        case 1:
                            system("cls");
                            cout<<"modelo da lampada"<<endl;
                            cout<<"1-lampada led"<<endl;
                            cout<<"2-lampada incandescente"<<endl;
                            cout<<"3-lampada fluorescente"<<endl;
                            cout<<"4-lampada tubular"<<endl;
                            cout<<"5-lustre"<<endl;

                            cin>>lquimc;
                            

                            if(lquimc=="1"){lquim=10;
                            }else if(lquimc=="2"){lquim=100;
                            }else if(lquimc=="3"){lquim=23;
                            }else if(lquimc=="4"){lquim=40;     
                            }else if(lquimc=="5"){lquim=100;
                            }else{cout<<"opicao invalida"<<endl;break;}

                            cout<<"quantidade de lampada"<<endl;
                            cin>>lquim1;  
                            // lquimres=lquim*lquim1;
                            break;
                        case 2:
                            system("cls");
                            cout<<"modelo do aquecedor de picina 127 volts"<<endl;
                            cout<<"1-aquecedor de picina 127 volts"<<endl;
                            cout<<"2-aquecedor de picina 220 volts"<<endl;

                            cin>>aquqs;
                            

                            if(aquqs=="1"){aquq=2000;
                            }else if(aquqs=="2"){aquq=5000;            
                            }else{cout<<"opicao invalida"<<endl;break;}

                            cout<<"quantidade de aquecedor de picina "<<endl;
                            cin>>aquq1;       
                            // aquqres=aquq*aquq1;
                            break;
                        case 3:
                            system("cls");
                            cout<<"modelo da churrasqueira"<<endl;
                            cout<<"1-churrasqueira 127 volts"<<endl;
                            cout<<"2-churrasqueira 220 volts"<<endl;

                            cin>>churrs;

                            

                            if(churrs=="1"){churr=1500;
                            }else if (churr==2){churr=3000;            
                            }else{cout<<"opicao invalida"<<endl;break;}

                            cout<<"quantidade de churrasqueiras"<<endl;
                            cin>>churr1;           
                            // churrres=churr*churr1;
                        break;
         
                    }

                      
                break;

            case 5:
                system("cls");
                cout<<"1-lampadas"<<endl;
                cout<<"2-cafeteira"<<endl;
                cout<<"3-geladeira"<<endl;
                cout<<"4-fogao electrico"<<endl;
                cout<<"5-microondas"<<endl;
                cout<<"6-forno elétrico"<<endl;
                cout<<"7-torradeira"<<endl;
                cout<<"8-torneira eletrica"<<endl;
                cout<<"9-enbulidor"<<endl;
                cout<<"10-espremedor de frutas"<<endl;
                cout<<"11-ar condicionado"<<endl;
                cout<<"12-batedeira"<<endl;
                cout<<"13-liquidificador"<<endl;


                cin>>opcc;

                if (opcc=="1"){opc=1; }
                else if (opcc=="2"){opc=2; }
                else if (opcc=="3"){opc=3; }
                else if (opcc=="4"){opc=4; }
                else if (opcc=="5"){opc=5; }
                else if (opcc=="6"){opc=6; }
                else if (opcc=="7"){opc=6; }
                else if (opcc=="8"){opc=6; }
                else if (opcc=="9"){opc=6; }
                else if (opcc=="10"){opc=6; }
                else if (opcc=="11"){opc=6; }
                else if (opcc=="12"){opc=6; }
                else if (opcc=="13"){opc=6; }
                else{cout<<"opicao invalida"<<endl;break;}    
               

                
                

                switch(opc){
                    case 1:
                        system("cls");
                        cout<<"modelo da lampada"<<endl;
                        cout<<"1-lampada led"<<endl;
                        cout<<"2-lampada incandescente"<<endl;
                        cout<<"3-lampada fluorescente"<<endl;
                        cout<<"4-lampada tubular"<<endl;
                        cout<<"5-lustre"<<endl;

                        cin>>lcozc;
                        

                        if(lcozc=="1"){lcoz=10;
                        }else if(lcozc=="2"){lcoz=100;
                        }else if(lcozc=="3"){lcoz=23;
                        }else if(lcozc=="4"){lcoz=40;
                        }else if(lcozc=="5"){lcoz=100;
                        }else{cout<<"opicao invalida"<<endl;break;} 

                        cout<<"quantidade de lampada"<<endl;
                        cin>>lcoz1;
                        // lcozres=lcoz*lcoz1;
                        break;
                    case 2:
                        system("cls");
                        cout<<"modelo da cafeteira"<<endl;
                        cout<<"1-cafeteira simples"<<endl;
                        cout<<"2-cafeteira Industrial  20 litros"<<endl;

                        cin>>cafecs;
                        

                        if(cafecs=="1"){cafec=500;
                        }else if(cafecs=="2"){cafec=4000;    
                        }else{cout<<"opicao invalida"<<endl;break;}

                        cout<<"quantidade de cafeteira"<<endl;
                        cin>>cafec1;
                        // cafecres=cafec*cafec1;
                        break;
                    case 3:
                        system("cls");
                        cout<<"modelo da geladeira"<<endl;
                        cout<<"1-geladeira simples"<<endl;
                        cout<<"2-geladeira duplex"<<endl;
                        cout<<"3-freezer vertical"<<endl;
                        cout<<"4-freezer horizontal"<<endl;

                        cin>>gelcs;

                        

                        if(gelcs=="1"){gelc=200;
                        }else if(gelcs=="2"){gelc=500;    
                        }else if(gelcs=="3"){gelc=300;
                        }else if(gelcs=="4"){ gelc=500;   
                        }else{cout<<"opicao invalida"<<endl;break;}

                        cout<<"quantidade de geladeira"<<endl;
                        cin>>gelc1;
                        // gelcres=gelc*gelc1;
                        break;
                    case 4:
                        system("cls");
                        cout<<"modelo do fogao electrico"<<endl;
                        cout<<"1-fogao electrico 1 bocas"<<endl;
                        cout<<"2-fogao electrico 2 bocas"<<endl;
                        cout<<"3-fogao electrico 4 bocas"<<endl;
                                    

                        cin>>fogcs;
                        

                        if(fogcs=="1"){fogc=1000;
                        }else if(fogcs=="2"){fogc=3000;    
                        }else if(fogcs=="3"){fogc=6000;
                        }else{cout<<"opicao invalida"<<endl;break;} 

                        cout<<"quantidade de fogao electrico"<<endl;
                        cin>>fogc1;
                        //fogcres=fogc*fogc1;
                        break;
                    case 5:
                        system("cls");
                        cout<<"modelo do microondas"<<endl;
                        cout<<"1-microondas 20 litros"<<endl;
                        cout<<"2-microondas 30 litros"<<endl;
                        cout<<"3-microondas maior que 30 litros"<<endl;
                        cout<<"4-microondas menor que 20 litros"<<endl;
                                    

                        cin>>miccs;
                        

                        if(miccs=="1"){micc=1150;
                        }else if(miccs=="2"){micc=1500;   
                        }else if(miccs=="3"){micc=3000;
                        }else if(miccs=="4"){micc=500;     
                        }else{cout<<"opicao invalida"<<endl;break;} 

                        cout<<"quantidade de microondas"<<endl;
                        cin>>micc1;
                        //miccres=micc*micc1;
                        break;
                    case 6:
                        system("cls");
                        cout<<"modelo do forno elétrico"<<endl;
                        cout<<"1-forno elétrico pequeno"<<endl;
                        cout<<"2-forno elétrico grande"<<endl;

                        cin>>forcs;
                        
                        if(forcs=="1"){forc=1500;
                        }else if(forcs=="2"){ forc=4500;    
                        }else{cout<<"opicao invalida"<<endl;break;}

                        cout<<"quantidade de forno elétrico"<<endl;
                        cin>>forc1;
                        // forcres=forc*forc1;
                        break;
                    case 7:
                        system("cls");
                        cout<<"modelo da torradeira"<<endl;
                        cout<<"1-torradeira simples"<<endl;
                        cout<<"2-torradeira 220 volt"<<endl;

                        cin>>torcs;
                        

                        if(torcs=="1"){torc=4500;
                        }else if(torcs=="2"){torc=6000;    
                        }else{cout<<"opicao invalida"<<endl;break;} 

                        cout<<"quantidade de torradeira"<<endl;
                        cin>>torc1;
                        // torcres=torc*torc1;
                        break;
                    case 8:
                        system("cls");
                        cout<<"modelo da torrneira"<<endl;
                        cout<<"1-torrneira simples"<<endl;
                        cout<<"2-torrneira 220 volt"<<endl;

                        cin>>trns;
                        

                        if(trns=="1"){trn=2600;
                        }else if(trns=="2"){trn=3600;     
                        }else{cout<<"opicao invalida"<<endl;break;}
                        
                        cout<<"quantidade de torrneira"<<endl;
                        cin>>trn1;
                        // trnres=trn*trn1;
                        break;
                    case 9:
                        system("cls");
                        cout<<"modelo do enbulido"<<endl;
                        cout<<"1-enbulido simples"<<endl;
                        cout<<"2-enbulido 220 volt"<<endl;

                        cin>>enbcs;
                        

                        if(enbcs=="1"){enbc=1000;
                        }else if(enbcs=="2"){enbc=2000;
                        }else{cout<<"opicao invalida"<<endl;break;}

                        cout<<"quantidade de enbulido"<<endl;
                        cin>>enbc1;
                        //enbcres=enbc*enbc1;
                        break;
                    case 10:
                        system("cls");
                        cout<<"modelo espremedor de frutas"<<endl;
                        cout<<"1-espremedor de frutas simples"<<endl;
                        cout<<"2-espremedor de frutas 220 volt"<<endl;

                        cin>>espcs;
                        

                        if(espcs=="1"){espc=200;
                        }else if(espcs=="2"){ espc=500;   
                        }else{cout<<"opicao invalida"<<endl;break;} 

                        cout<<"quantidade de espremedor de frutas"<<endl;
                        cin>>espc1;
                        // espcres=espc*espc1;
                        break;
                    case 11:
                        system("cls");
                        cout<<"modelo do ar condicionado"<<endl;
                        cout<<"1-ar condicionado 7500btu"<<endl;
                        cout<<"2-ar condicionado 10000btu"<<endl;
                        cout<<"3-ar condicionado 12000btu"<<endl;
                        cout<<"4-ar condicionado 15000btu"<<endl;
                        cout<<"5-ventilador de teto"<<endl;
                        cout<<"6-ventilador "<<endl;

                        cin>>arcs;
                        

                        if(arcs=="1"){arc=1000;
                        }else if(arcs=="2"){arc=1350;     
                        }else if(arcs=="3"){arc=1500;
                        }else if(arcs=="4"){arc=2000;    
                        }else if(arcs=="5"){arc=120;
                        }else if(arcs=="6"){ arc=100;   
                        }else{cout<<"opicao invalida"<<endl;break;} 

                        cout<<"quantidade de ar condicionado"<<endl;
                        cin>>arc1;
                        //arcres=arc*arc1;
                        break;
                    case 12:
                        system("cls");
                        cout<<"modelo da batedeira"<<endl;
                        cout<<"1-batedeira simples"<<endl;
                        cout<<"2-batedeira 220 volt"<<endl;

                        cin>>batcs;
                        

                        if(batcs=="1"){batc=500;
                        }else if(batcs=="2"){batc=750;    
                        }else{cout<<"opicao invalida"<<endl;break;}

                        cout<<"quantidade de batedeira"<<endl;
                        cin>>batc1;
                        // batcres=batc*batc1;
                       break;
                    case 13:
                        system("cls");
                        cout<<"modelo do liquidificador"<<endl;
                        cout<<"1-liquidificador simples"<<endl;
                        cout<<"2-liquidificador 220 volt"<<endl;

                        cin>>liqcs;
                        

                        if(liqcs=="1"){liqc=500;
                        }else if(liqcs=="2"){liqc=750;    
                        }else{cout<<"opicao invalida"<<endl;break;} 

                        cout<<"quantidade de liquidificador"<<endl;
                        cin>>liqc1;
                        // liqcres=liqc*liqc1;
                    break;

                }

                break;
            
            case 6:
                system("cls");
                cout<<"1-enceradeira"<<endl;
                cout<<"2-aspirador de po"<<endl;

                cin>>opcc;
                if (opcc=="1"){opc=1; }
                else if (opcc=="2"){opc=2; }
                else{cout<<"opicao invalida"<<endl;break;}


                switch(opc){
                    case 1:
                        system("cls");
                        cout<<"modelo da enceradeira"<<endl;
                        cout<<"1-enceradeira 127 volts"<<endl;
                        cout<<"2-enceradeira 220 volts"<<endl;
                                        

                        cin>>encs;
                        

                        if(encs=="1"){enc=500;
                        }else if (encs=="2"){enc=1000;}// encres=enc*enc1; 
                        else{cout<<"opicao invalida"<<endl;break;} 

                        cout<<"quantidade de enceradeira"<<endl;
                        cin>>enc1;
                          
                        break;
                    case 2:
                        system("cls");
                        cout<<"modelo do aspirador de po"<<endl;
                        cout<<"1-aspirador de po simples"<<endl;
                        cout<<"2-aspirador de po 220 volt"<<endl;

                        cin>>asps;
                        
                        if(asps=="1"){asp=1500;
                        }else if(asps=="2"){ asp=2000;   //  aspres=asp*asp1;
                        }else{cout<<"opicao invalida"<<endl;break;}

                        cout<<"quantidade de aspirador de po"<<endl;
                        cin>>asp1;
                    break;
                                   
                }
                           
                break;
            case 7:
                system("cls");
                cout<<"1-impresora"<<endl;
                cout<<"2-coputador"<<endl;
                cout<<"3-lampadas"<<endl;
                cout<<"4-ar condicionado"<<endl;


                cin>>opcc;
                
                if (opcc=="1"){opc=1; }
                else if (opcc=="2"){opc=2; }
                else if (opcc=="3"){opc=3; }
                else if (opcc=="4"){opc=4; }
                else{cout<<"opicao invalida"<<endl;break;}

                switch(opc){
                    case 1:
                        cout<<"modelo da impresora"<<endl;
                        cout<<"1-impresora multifuncional"<<endl;
                        cout<<"2-impresora laser"<<endl;
                        cout<<"3-impresora grade"<<endl;
                        cout<<"4-impresora 3d"<<endl;


                        cin>>imp;
                        

                        if(imps=="1"){imp=400;
                        }else if(imps=="2"){imp=600;                        
                        }else if(imps=="3"){imp=1000;                    
                        }else if(imps=="4"){ imp=1500;                       
                        }else{cout<<"opicao invalida"<<endl;break;}

                        cout<<"quantidade de impresora"<<endl;
                        cin>>imp1;
                        // impres=imp*imp1;
                        break;
                    case 2:
                        cout<<"modelo do coputador"<<endl;
                        cout<<"1-coputador simples"<<endl;
                        cout<<"2-coputador gamer"<<endl;
                        cout<<"3-coputador escritorio"<<endl;

                        cin>>cops;
                        
                        if(cops=="1"){cop=300;
                        }else if(cops=="2"){ cop=500;                       
                        }else if(cops=="3"){cop=400;                    
                        }else{cout<<"opicao invalida"<<endl;break;}

                        cout<<"quantidade de coputador"<<endl;
                        cin>>cop1;
                        // copres=cop*cop1;
                        break;
                    case 3:
                        cout<<"modelo das lampadas"<<endl;
                        cout<<"1-lampada led"<<endl;
                        cout<<"2-lampada incandescente"<<endl;
                        cout<<"3-lampada fluorescente"<<endl;
                        cout<<"4-lampada tubular"<<endl;
                        cout<<"5-lampada lustre"<<endl;

                        cin>>les;
                        

                        if(les=="1"){le=10;
                        }else if(les=="2"){le=100;                        
                        }else if(les=="3"){ le=20;                   
                        }else if(les=="4"){le=40;                        
                        }else if(les=="5"){le=50;                    
                        }else{cout<<"opicao invalida"<<endl;break;}

                        cout<<"quantidade de lampadas"<<endl;
                        cin>>le1;
                        // leres=le*le1;
                        break;
                    case 4:
                        cout<<"modelo do ar condicionado"<<endl;
                        cout<<"1-ar condicionado 75000 btu"<<endl;
                        cout<<"2-ar condicionado 150000 btu"<<endl;
                        cout<<"3-ar condicionado 120000 btu"<<endl;
                        cout<<"4-ar condicionado siples"<<endl;
                        cout<<"5-ventilador de teto"<<endl;
                        cout<<"6-ventilador siples"<<endl;
                        cout<<"7-ar condicionado 180000 btu"<<endl;


                        cin>>ares;
                        

                        if(ares=="1"){are=1000;
                        }else if(ares=="2"){are=2000;                        
                        }else if(ares=="3"){are=1500;                    
                        }else if(ares=="4"){ are=500;                       
                        }else if(ares=="5"){ are=120;                   
                        }else if(ares=="6"){are=100;                        
                        }else if(ares=="7"){are=2100;                    
                        }else{cout<<"opicao invalida"<<endl;break;}

                        cout<<"quantidade de ar condicionado"<<endl;
                        cin>>are1;
                        // areres=are*are1;
                    break;
                                       
                }

                                
                break;
            case 8:
                system("cls");
                cout<<"1-maquina de lavar"<<endl;
                cout<<"2-ferro de passar"<<endl;
                cout<<"3-maquina de secar"<<endl;
                cout<<"4-maquina de lavar e secar"<<endl;
                cout<<"5-lampadas"<<endl;

                cin>>opcc;

                if (opcc=="1"){opc=1; }
                else if (opcc=="2"){opc=2; }
                else if (opcc=="3"){opc=3; }
                else if (opcc=="4"){opc=4; }
                else if (opcc=="5"){opc=5; }
                else{cout<<"opicao invalida"<<endl;break;}

                
                
                switch(opc){
                    case 1:
                        system("cls");
                        cout<<"modelo da maquina de lavar"<<endl;
                        cout<<"1-maquina de lavar 8kg"<<endl;
                        cout<<"2-maquina de lavar 10kg"<<endl;
                        cout<<"3-maquina de lavar 12kg"<<endl;
                        cout<<"4-maquina de lavar 14kg"<<endl;
                        cout<<"5-maquina de lavar 16kg"<<endl;
                        cout<<"6-maquina de lavar 18kg"<<endl;
                        cout<<"7-maquina de lavar 20kg"<<endl;

                        cin>>lavs;


                        

                        if(lavs=="1"){lav=200;                            
                        }else if(lavs=="2"){lav=400;
                        }else if(lavs=="3"){lav=500;
                        }else if(lavs=="4"){lav=600;                        
                        }else if(lavs=="5"){lav=700;                    
                        }else if(lavs=="6"){lav=800;                       
                        }else if(lavs=="7"){lav=900;}
                        else{cout<<"opicao invalida"<<endl;break;}                    
                              
                        cout<<"quantidade de maquina de lavar"<<endl;
                        cin>>lav1;                   
                        // lavres=lav*lav1;
                        break;
                    case 2:
                        system("cls");
                        cout<<"modelo do ferro de passar"<<endl;
                        cout<<"1-ferro de passar 127 volts"<<endl;
                        cout<<"2-ferro de passar 220 volts"<<endl;

                        cin>>fers;

                       

                        if(fers=="1"){fer=1000;
                        }else if(fers=="2"){fer=1500;}
                        else{cout<<"opicao invalida"<<endl;break;}

                        cout<<"quantidade de ferro de passar"<<endl;
                        cin>>fer1;

                       //ferres=fer*fer1;
                        break;
                    case 3:
                        system("cls");
                        cout<<"modelo da maquina de secar"<<endl;
                        cout<<"1-maquina de secar 127 volts"<<endl;
                        cout<<"2-maquina de secar 220 volts"<<endl;
                        cin>>secls;

                                           
                        
                        if(secls=="1"){secl=1500;}else if(secls=="2"){secl=3500;}else{cout<<"opicao invalida"<<endl;break;}                  
                        
                        cout<<"quantidade de maquina de secar"<<endl;                   
                        cin>>secl1; 
                        
                        //seclres=secl*secl1;
                        break;
                    case 4:
                        system("cls");
                        cout<<"modelo da maquina de lavar e secar"<<endl;
                        cout<<"1-maquina de lavar e secar 8kg"<<endl;
                        cout<<"2-maquina de lavar e secar 10kg"<<endl;
                        cout<<"3-maquina de lavar e secar 12kg"<<endl;
                        cout<<"4-maquina de lavar e secar 14kg"<<endl;
                        cout<<"5-maquina de lavar e secar 16kg"<<endl;
                        cout<<"6-maquina de lavar e secar 18kg"<<endl;
                        cout<<"7-maquina de lavar e secar 20kg"<<endl;

                        cin>>lavses;
                        

                        if(lavses=="1"){lavse=1000;
                        }else if(lavses=="2"){lavse=1500;                        
                        }else if(lavses=="3"){lavse=2000;                    
                        }else if(lavses=="4"){lavse=2500;                        
                        }else if(lavses=="5"){lavse=3000;                    
                        }else if(lavses=="6"){lavse=3500;                        
                        }else if(lavses=="7"){lavse=4000; } 
                        else{cout<<"opicao invalida"<<endl;break;}

                        cout<<"quantidade de maquina de lavar e secar"<<endl;
                        cin>>lavse1;

                        // lavseres=lavse*lavse1;                        
                  
                        break;
                    case 5:
                        system("cls");
                        cout<<"modelo da lampada"<<endl;
                        cout<<"1-led"<<endl;
                        cout<<"2-encadecete amarela"<<endl;
                        cout<<"3-fluorescente"<<endl;
                        cout<<"4-lustre"<<endl;
                        cout<<"5-tubular"<<endl;
                        cin>>lss;

                       

                        if(lss=="1"){lam=10;
                        }else if(lss=="2"){ lam=100;               
                        }else if(lss=="3"){ lam=23;          
                        }else if(lss=="4"){ lam=100;               
                        }else if(lss=="5"){lam=40; 
                        }else{cout<<"opicao invalida"<<endl;break;}  
                        break;

                        cout<<"quantidade de lampadas"<<endl;
                        cin>>ls1;


                        
                            
                    }

                              
                break;
            case 9:
                    system("cls");
                    cout<<"tipo de ferramentas"<<endl;
                    cout<<"1-cortador de grama"<<endl;
                    cout<<"2-aspirador "<<endl;
                    cout<<"3-bomba de agua"<<endl;
                    cout<<"4-furadeira"<<endl;
                    cout<<"5-makita"<<endl;
                    cout<<"6-serra elétrica"<<endl;
                    cout<<"7-copressor"<<endl; 
                    cout<<"8-ferro de solda"<<endl;
                                
                                
                                

                    cin>>opcc;

                    if (opcc=="1"){opc=1; }
                    else if (opcc=="2"){opc=2; }
                    else if (opcc=="3"){opc=3; }
                    else if (opcc=="4"){opc=4; }
                    else if (opcc=="5"){opc=5; }
                    else if (opcc=="6"){opc=6; }
                    else if (opcc=="7"){opc=6; }
                    else if (opcc=="8"){opc=6; }
                    else{cout<<"opicao invalida"<<endl;break;}

                    switch(opc){
                        case 1:
                            system("cls");
                            cout<<"modelo do cortador de grama"<<endl;
                            cout<<"1-cortador de grama 127 volts"<<endl;
                            cout<<"2-cortador de grama 220 volts"<<endl;

                            cin>>corts;
                            

                            if(corts=="1"){cort=500;}else if(corts=="2"){cort=1000;}else{cout<<"opicao invalida"<<endl;break;}
                            
                            cout<<"quantidade de cortador de grama"<<endl;
                            cin>>cort1;
                            //cortres=cort*cort1;
                            break;
                        case 2:
                            system("cls");
                            cout<<"modelo do aspirador"<<endl;
                            cout<<"1-aspirador pequeno"<<endl;
                            cout<<"2-aspirador grande"<<endl;
                            cout<<"3-aspirador robotico"<<endl;

                            cin>>aspc;
                            
                            if(asps=="1"){asp=500;
                            }else if(aspc=="2"){asp=1500;                   
                            }else if(aspc=="3"){asp=100; } 
                            else{cout<<"opicao invalida"<<endl;break;} 

                            cout<<"quantidade de aspirador"<<endl;
                            cin>>asp1;            
                            //aspres=asp*asp1;                     
                            break;
                        case 3:
                            system("cls");
                            cout<<"modelo da bomba de agua"<<endl;
                            cout<<"1-bomba de agua 127 volts"<<endl;
                            cout<<"2-bomba de agua 220 volts"<<endl;

                            cin>>boms;
                            
                            if(boms=="1"){bom=500;
                            }else if(boms=="2"){bom=1000;} 
                            else{cout<<"opicao invalida"<<endl;break;}

                            cout<<"quantidade de bomba de agua"<<endl;
                            cin>>bom1;                  
                            //bomres=bom*bom1;
                            break;
                        case 4:
                            system("cls");
                            cout<<"modelo da furadeira"<<endl;
                            cout<<"1-furadeira com impacto"<<endl;
                            cout<<"2-furadeira sem impacto"<<endl;

                            cin>>furs;
                            

                            if(furs=="1"){fur=500;
                            }else if(furs=="2"){ fur=1000; }
                            else{cout<<"opicao invalida"<<endl;break;}

                            cout<<"quantidade de furadeira"<<endl;
                            cin>>fur1;

                            //furres=fur*fur1;
                            break;
                        case 5:
                            system("cls");
                            cout<<"modelo da makita"<<endl;
                            cout<<"1-makita 127 volts"<<endl;
                            cout<<"2-makita 220 volts"<<endl;

                            cin>>maks;

                            

                            if(maks=="1"){mak=1000;
                            }else if(maks=="2"){ mak=1500;} 
                            else{cout<<"opicao invalida"<<endl;break;}

                            cout<<"quantidade de makita"<<endl;
                            cin>>mak1;

                            // makres=mak*mak1;
                            break;
                        case 6:
                            system("cls");
                            cout<<"modelo da serra elétrica"<<endl;
                            cout<<"1-serra elétrica tico tico"<<endl;
                            cout<<"2-serra elétrica circular"<<endl;
                            cout<<"3-serra elétrica sabre"<<endl;
                            cout<<"4-serra elétrica de mesa"<<endl;
                            cout<<"5-moto serra eletrica"<<endl;

                            cin>>sers;

                            

                            if(sers=="1"){ser=700;                
                            }else if(sers=="2"){ ser=1600;                   
                            }else if(sers=="3"){ser=1000;                
                            }else if(sers=="4"){ ser=2200;                   
                            }else if(sers=="5"){ ser=3000; }
                            else{cout<<"opicao invalida"<<endl;break;}

                            cout<<"quantidade de serra elétrica"<<endl;
                            cin>>ser1;              
                            //serres=ser*ser1;
                            break;
                        case 7:
                            system("cls");
                            cout<<"modelo do copressor"<<endl;
                            cout<<"1-copressor pequeno"<<endl;
                            cout<<"2-copressor medio"<<endl;
                            cout<<"3-copressor grande"<<endl;

                            cin>>copfs;

                           
                            if(copfs=="1"){copf=500;
                            }else if(copfs=="2"){ copf=1000;
                            }else if(copfs=="3"){copf=1500;}
                            else{cout<<"opicao invalida"<<endl;break;}

                            cout<<"quantidade de copressor"<<endl;
                            cin>>copf1;                       
                            //copfres=copf*copf1;
                            break;
                        case 8:
                            system("cls");
                            cout<<"modelo do ferro de solda"<<endl;
                            cout<<"1-ferro de solda 127 volts"<<endl;
                            cout<<"2-ferro de solda 220 volts"<<endl;

                            cin>>ferfs;
                            
                            if(ferfs=="1"){ferf=1000;
                            }else if(ferfs=="2"){ferf=1500;}
                            else{cout<<"opicao invalida"<<endl;break;}

                            cout<<"quantidade de ferro de solda"<<endl;
                            cin>>ferf1;                        
                            // ferfres=ferf*ferf1;
                        break;


                    }


                break;
            case 10:
                system("cls");
                cout<<"1-telefone celular"<<endl;
                cout<<"2-slide"<<endl;
                cout<<"3-adiciona watts manualmente exemplo 1000"<<endl;

                cin>>opcc;

                if (opcc=="1"){opc=1; }
                else if (opcc=="2"){opc=2; }
                else if (opcc=="3"){opc=3; }
              
                else{cout<<"opicao invalida"<<endl;break;}    
               
                
                switch(opc){
                    case 1:
                        system("cls");
                        cout<<"modelo do telefone celular"<<endl;
                        cout<<"1-telefone celular"<<endl;
                                                
                        cin>>telc;

                        
                        if(telc=="1"){tel=5;}
                        if (opcc=="1"){opc=1; }
               
                        else{cout<<"opicao invalida"<<endl;break;}

                        cout<<"quantidade de telefone celular"<<endl;
                        cin>>tel1;
                        //telres=tel*tel1;
                        break;
                    case 2:
                        system("cls");
                        cout<<"modelo do slide"<<endl;
                        cout<<"1-slide"<<endl;
                                            
                        cin>>slids;
                        
                        if(slids=="1"){slid=200;}
                        else{cout<<"opicao invalida"<<endl;break;} 

                        cout<<"quantidade de slide"<<endl;
                        cin>>slid1;
                        // slidres=slid*slid1;
                        break;
                    case 3:
                            system("cls");
                            cout<<"quantidade de watss"<<endl;
                            cin>>watts;
                    break;


                                         
                }
                          
               break;
            default:
                cout<<"opicao invalida"<<endl;
              
            break;


                   
        }

       

        cout<<"Deseja adicionar mais (s/n)"<<endl;
        cin>>perg;
 
    } 

    telres=tel*tel1; serres=ser*ser1; makres=mak*mak1; slidres=slid*slid1;  ferfres=ferf*ferf1;
    copfres=copf*copf1; lavseres=lavse*lavse1; seclres=secl*secl1; impres=imp*imp1; aspres=asp*asp1;
    furres=fur*fur1; cortres=cort*cort1; ferres=fer*fer1; aspres=asp*asp1; encres=enc*enc1;
    bomres=bom*bom1; leres=le*le1; lavres=lav*lav1; copres=cop*cop1; batcres=batc*batc1;
    aspres=asp*asp1; seclres=secl*secl1; areres=are*are1; arcres=arc*arc1; espcres=espc*espc1;
    enbcres=enbc*enbc1; churrres=churr*churr1; lquimres=lquim*lquim1; aquqres=aquq*aquq1;
    trnres=trn*trn1; lambres=lamb*lamb1; aqures=aqu*aqu1; chapres=chap*chap1; secres=sec*sec1;
    torcres=torc*torc1; chbres=chb*chb1; comqres=comq*comq1; lamqres=lamq*lamq1; tvqres=tvq*tvq1;
    forcres=forc*forc1; arqres=arq*arq1; dvdsres=dvds*dvds1;vsalares=vsala*vsala1;gelcres=gelc*gelc1; 
    miccres=micc*micc1; sonqres=sonq*sonq1; arres=ars*ars1; lcozres=lcoz*lcoz1;lampadasres=lampadas*lampadas1;
    fogcres=fogc*fogc1; sonsres=sons*sons1;tvsres=tvs*tvs1; cafecres=cafec*cafec1;lamres=lam*ls1;
    
  
   

    banheiores= chbres+secres+chapres+aqures+lambres; quintalres= lquimres+aquqres+churrres;
    quartores= tvqres+lamqres+arqres+sonqres+comqres; outrosres= telres+slidres+watts+encres+aspres;  
    ferramentasres= cortres+aspres+bomres+furres+makres+serres+copfres+ferfres; cozinhares= lcozres+cafecres+gelcres+fogcres+miccres+forcres+enbcres+espcres+arcres+batcres+liqcres+trnres;
    salares= tvsres+lampadasres+arres+sonsres+vsalares+dvdsres; lavadeiriares= lavres+ferres+seclres+lavseres; 
    iluminares= lamres+lambres+lamqres+lampadasres; escritoriores= impres+copres+leres+areres+lamres; 
    //limpezares= encres+aspres; 
    
    res= encres+aspres+impres+copres+leres+tvs1+arres+sonsres+churrres+trnres+
    tvqres+lamqres+arqres+sonqres+comqres+tvsres+lampadasres+chbres+secres+lamres+
    chapres+aqures+lambres+lquimres+aquqres+lcozres+vsalares+dvdsres+cafecres+gelcres+
    fogcres+miccres+forcres+torcres+enbcres+espcres+arcres+batcres+liqcres+lavres+ferres+
    seclres+lavseres+cortres+bomres+furres+makres+serres+copfres+ferfres+telres+slidres+
    watts+iluminares;


    
    

   
    if(iluminares<=1000 && iluminares>1){djilum=10;fioilu=1.5;}else if(iluminares>=3000){djilum=25;fioilu=2.5;}else if(iluminares>5000){djilum=40;fioilu=4;}
    if(salares<=1000 && salares>1) {djs=10;fios=1.5;}else if (salares>=2000){djs=20;fios=2.5;}else if(salares>=3000){djs=30;fios=3;}else if(salares>5000){djs=40;fios=6;}
    if(quartores<=1000 && quartores>1) {djq=10;fioq=1.5;}else if (quartores>=2000){djq=20;fioq=2.5;}else if(quartores>=3000){djq=30;fioq=3;}else if(quartores>5000){djq=40;fioq=6;}
    if(quintalres<=1000 && quintalres>1) {djqui=10;fioquim=1.5;}else if (quintalres>=2000){djqui=20;fioquim=2.5;}else if(quintalres>=3000){djqui=30;fioquim=3;}else if(quintalres>5000){djqui=40;fioquim=6;}
    if(lavadeiriares<=1000 && lavadeiriares>1) {djl=10;fiol=1.5;}else if (lavadeiriares>=2000){djl=20;fiol=2.5;}else if(lavadeiriares>=3000){djl=30;fiol=3;}else if(lavadeiriares>5000){djl=40;fiol=6;}
    if(ferramentasres<=1000 && ferramentasres>1){djfer=10;fiofer=1.5;}else if(ferramentasres>=3000){djfer=25;fiofer=2.5;}else if(ferramentasres>5000){djfer=40;fiofer=4;}
    if(escritoriores<=1000 && escritoriores>1){dje=10;fioe=1.5;}else if(escritoriores>=3000){dje=25;fioe=2.5;}else if(escritoriores>5000){dje=40;fioe=4;}      
    if(cozinhares<=1000 && cozinhares>1){djc=10;fioc=1.5;}else if(cozinhares>=3000){djc=25;fioc=2.5;}else if(cozinhares>5000){djc=40;fioc=4;}
    if(banheiores<=1000 && banheiores>1){djb=10;fiob=1.5;}else if(banheiores>=3000){djb=25;fiob=2.5;}else if(banheiores>5000){djb=40;fiob=4;}
    if(outrosres<=1000 && outrosres>1){djo=10;fioo=1.5;}else if(outrosres>=3000){djo=25;fioo=2.5;}else if(outrosres>5000){djo=40;fioo=4;}

            
    if(res<=8000){djprim=60;fiop=10;}else if(res>=7000){djprim=70;fiop=12;}
    if(res>12000 ){ djprim=70;fiop=10;}else if(res>=16000){djprim=100;fiop=14;} 
    if(res>16000){djprim=100;fiop=14;}else if(res>20000){djprim=120;fiop=16;}
    
    if(res<=8000){padrao='m';}else if(res>8200){ padrao='b';}else if(res>16000){padrao='t';}

    switch (padrao){
        case 'm':
            
            
            cout<<"padrao monofasico"<<endl;
            
            cout<<"potencia da sala:   "<<salares<<"  watts"<<endl;
            cout<<"potencia dos quartos:   "<<quartores<<"  watts"<<endl;
            cout<<"potencia do quintal:   "<<quintalres<<"  watts"<<endl;
            cout<<"potencia da lavadeiria:   "<<lavadeiriares<<"  watts"<<endl;
            cout<<"potencia das ferramentas:   "<<ferramentasres<<"  watts"<<endl;
            cout<<"potencia do escritorio:   "<<escritoriores<<"  watts"<<endl;
            cout<<"potencia da cozinha:   "<<cozinhares<<"  watts"<<endl;       
            cout<<"potencia do banheiro:   "<<banheiores<<"  watts"<<endl;
            cout<<"potencia de outros:   "<<outrosres<<"  watts"<<endl;
            cout<<"potencia da  iluminacao:   "<<iluminares<<"  watts"<<endl;
            cout<<"potencia total do padrao:  "<<res<<"  watts"<<endl;
            cout<<"-----------------------------------------------------"<<endl;

           

            
            cout<<"dinjuntores:"<<endl;

            cout<<"1 dinjunto primcipal:  "<<djprim<<"  amperes"<<endl;  
            cout<<"1 dinjunto iluminacao:  "<<djilum<<"  ampres"<<endl;
            cout<<"1 dinjunto da sala:   "<<djs<<"  amperes"<<endl;
            cout<<"1 dinjunto do quartos:   "<<djq<<"  amperes"<<endl;
            cout<<"1 dinjunto do quintal:   "<<djqui<<"  amperes"<<endl;
            cout<<"1 dinjunto das ferramentas:   "<<djfer<<"  amperes"<<endl;
            cout<<"1 dinjunto da lavadeiria:   "<<djl<<"  amperes"<<endl;
            cout<<"1 dinjunto do escritorio:   "<<dje<<"  amperes"<<endl;
            cout<<"1 dinjunto da cozinha:   "<<djc<<"  amperes"<<endl;
            cout<<"1 dinjunto do banheiro:   "<<djb<<"  amperes"<<endl;
            cout<<"1 dinjunto de outros:   "<<djo<<"  amperes"<<endl;

            cout<<"-----------------------------------------------------"<<endl;

            cout<<"fios:"<<endl;


            cout<<"bitola de fios primcipal :  "<<fiop<<"  mm"<<endl; 

            cout<<"bitola de fios da sala:  "<<fios<<"  mm"<<endl;
            cout<<"bitola de fios dos quartos:  "<<fioq<<"  mm"<<endl;
            cout<<"bitola de fios do quintal:  "<<fioquim<<"  mm"<<endl;
            cout<<"bitola de fios da lavadeiria:  "<<fiol<<"  mm"<<endl;
            cout<<"bitola de fios das ferramentas:  "<<fiofer<<"  mm"<<endl;
            cout<<"bitola de fios do escritorio:  "<<fioe<<"  mm"<<endl;
            cout<<"bitola de fios da cozinha:  "<<fioc<<"  mm"<<endl;
            cout<<"bitola de fios d o banheiro:  "<<fiob<<"  mm"<<endl;
            cout<<"bitola de fios da iluminacao:  "<<fioilu<<"  mm"<<endl;
            cout<<"bitola de fios de outros:  "<<fioo<<"  mm"<<endl;          

            break;
        case 'b':
            cout<<"padrao bifasico"<<endl;

            cout<<"potencia da sala:   "<<salares<<"  watts"<<endl;
            cout<<"potencia dos quartos:   "<<quartores<<"  watts"<<endl;
            cout<<"potencia do quintal:   "<<quintalres<<"  watts"<<endl;
            cout<<"potencia da lavadeiria:   "<<lavadeiriares<<"  watts"<<endl;
            cout<<"potencia das ferramentas:   "<<ferramentasres<<"  watts"<<endl;
            cout<<"potencia do escritorio:   "<<escritoriores<<"  watts"<<endl;
            cout<<"potencia da cozinha:   "<<cozinhares<<"  watts"<<endl;
            cout<<"potencia do banheiro:   "<<banheiores<<"  watts"<<endl;
            cout<<"potencia de outros:   "<<outrosres<<"  watts"<<endl;
            cout<<"potencia da  iluminacao:   "<<iluminares<<"  watts"<<endl;
            cout<<"potencia total do padrao:  "<<res<<"  watts"<<endl;
            cout<<"-----------------------------------------------------"<<endl;

           
            
            cout<<"dinjuntores:"<<endl;

            cout<<"1 dinjunto primcipal:  "<<djprim<<"  amperes"<<endl;  
            cout<<"1 dinjunto iluminacao:  "<<djilum<<"  ampres"<<endl;
            cout<<"1 dinjunto da sala:   "<<djs<<"  amperes"<<endl;
            cout<<"1 dinjunto do quartos:   "<<djq<<"  amperes"<<endl;
            cout<<"1 dinjunto do quintal:   "<<djqui<<"  amperes"<<endl;
            cout<<"1 dinjunto das ferramentas:   "<<djfer<<"  amperes"<<endl;
            cout<<"1 dinjunto da lavadeiria:   "<<djl<<"  amperes"<<endl;
            cout<<"1 dinjunto do escritorio:   "<<dje<<"  amperes"<<endl;
            cout<<"1 dinjunto da cozinha:   "<<djc<<"  amperes"<<endl;
            cout<<"1 dinjunto do banheiro:   "<<djb<<"  amperes"<<endl;
            cout<<"1 dinjunto de outros:   "<<djo<<"  amperes"<<endl;

            cout<<"-----------------------------------------------------"<<endl;

            cout<<"fios:"<<endl;


            cout<<"bitola de fios primcipal:  "<<fiop<<"  mm"<<endl; 

            cout<<"bitola de fios da sala:  "<<fios<<"  mm"<<endl;
            cout<<"bitola de fios dos quartos:  "<<fioq<<"  mm"<<endl;
            cout<<"bitola de fios do quintal:  "<<fioquim<<"  mm"<<endl;
            cout<<"bitola de fios da lavadeiria:  "<<fiol<<"  mm"<<endl;
            cout<<"bitola de fios das ferramentas:  "<<fiofer<<"  mm"<<endl;
            cout<<"bitola de fios do escritorio:  "<<fioe<<"  mm"<<endl;
            cout<<"bitola de fios da cozinha:  "<<fioc<<"  mm"<<endl;
            cout<<"bitola de fios d o banheiro:  "<<fiob<<"  mm"<<endl;
            cout<<"bitola de fios da iluminacao:  "<<fioilu<<"  mm"<<endl;
            cout<<"bitola de fios de outros:  "<<fioo<<"  mm"<<endl;
            
            break;
        case 't':
            cout<<"padrao trifasico"<<endl;

            cout<<"potencia da sala:   "<<salares<<"  watts"<<endl;
            cout<<"potencia dos quartos:   "<<quartores<<"  watts"<<endl;
            cout<<"potencia do quintal:   "<<quintalres<<"  watts"<<endl;
            cout<<"potencia da lavadeiria:   "<<lavadeiriares<<"  watts"<<endl;
            cout<<"potencia das ferramentas:   "<<ferramentasres<<"  watts"<<endl;
            cout<<"potencia do escritorio:   "<<escritoriores<<"  watts"<<endl;
            cout<<"potencia da cozinha:   "<<cozinhares<<"  watts"<<endl;         
            cout<<"potencia do banheiro:   "<<banheiores<<"  watts"<<endl;
            cout<<"potencia de outros:   "<<outrosres<<"  watts"<<endl;
            cout<<"potencia da  iluminacao:   "<<iluminares<<"  watts"<<endl;
            cout<<"potencia total do padrao:  "<<res<<"  watts"<<endl;
            cout<<"-----------------------------------------------------"<<endl;

           
          
            cout<<"dinjuntores:"<<endl;

            cout<<"1 dinjunto primcipal:  "<<djprim<<"  amperes"<<endl;  
            cout<<"1 dinjunto iluminacao:  "<<djilum<<"  ampres"<<endl;
            cout<<"1 dinjunto da sala:   "<<djs<<"  amperes"<<endl;
            cout<<"1 dinjunto do quartos:   "<<djq<<"  amperes"<<endl;
            cout<<"1 dinjunto do quintal:   "<<djqui<<"  amperes"<<endl;
            cout<<"1 dinjunto das ferramentas:   "<<djfer<<"  amperes"<<endl;
            cout<<"1 dinjunto da lavadeiria:   "<<djl<<"  amperes"<<endl;
            cout<<"1 dinjunto do escritorio:   "<<dje<<"  amperes"<<endl;
            cout<<"1 dinjunto da cozinha:   "<<djc<<"  amperes"<<endl;
            cout<<"1 dinjunto do banheiro:   "<<djb<<"  amperes"<<endl;
            cout<<"1 dinjunto de outros:   "<<djo<<"  amperes"<<endl;

            cout<<"-----------------------------------------------------"<<endl;

            cout<<"fios:"<<endl;


            cout<<"bitola de fios primcipal:  "<<fiop<<"  mm"<<endl; 
            cout<<"bitola de fios da sala:  "<<fios<<"  mm"<<endl;
            cout<<"bitola de fios dos quartos:  "<<fioq<<"  mm"<<endl;
            cout<<"bitola de fios do quintal:  "<<fioquim<<"  mm"<<endl;
            cout<<"bitola de fios da lavadeiria:  "<<fiol<<"  mm"<<endl;
            cout<<"bitola de fios das ferramentas:  "<<fiofer<<"  mm"<<endl;
            cout<<"bitola de fios do escritorio:  "<<fioe<<"  mm"<<endl;
            cout<<"bitola de fios da cozinha:  "<<fioc<<"  mm"<<endl;
            cout<<"bitola de fios d o banheiro:  "<<fiob<<"  mm"<<endl;
            cout<<"bitola de fios da iluminacao:  "<<fioilu<<"  mm"<<endl;
            cout<<"bitola de fios de outros:  "<<fioo<<"  mm"<<endl;
        break;



    
    }


    cout<<"dejeja imprimir um pdf s/n "<<endl;
    cin>>pg;
    if(pg=='s'||pg=='S'){imprimir(); cout<<"imprimida com susesso local do arquivo ->pasta rais do calculador"<<endl;}
        
        
    
   
    system("pause");



                       

      

            
        
        
               
  
    return 0;
} 


     
int imprimir(){

    int padr;  char perg;  
    
    ofstream arq,arq1;
    
    
    arq.open("calculo de watts.txt");//cria o arquivo aterando o conteudo
    arq1.open("calculos de watts.txt",ios::app);//adiciona no arquivo nao apaga o arquivo
   
    //arq<<"teste\n";//escreve no arquivo
    //arq<<"teste2\n";
    // arq<<"teste3\n";


    if(res<=8000){padr=1; }if(res>=8500 ){padr=2; }if(res>16000){padr=3; }
    
    
    cout<<"como degeja imprimir s/ subistituir arquivo /c  nao subistituir o conteudo ezistente "<<endl;
    cin>>perg;
    switch (perg){
        case 's':
            switch (padr){
                //ofstream arq;
               // arq.open("calculo de watts.txt");



                case 1:
                    
                    
                    arq<<"padrao monofasico"<<endl;

                    
                    
                    arq<<"potencia da sala:   "<<salares<<"  watts"<<endl;
                    arq<<"potencia dos quartos:   "<<quartores<<"  watts"<<endl;
                    arq<<"potencia do quintal:   "<<quintalres<<"  watts"<<endl;
                    arq<<"potencia da lavadeiria:   "<<lavadeiriares<<"  watts"<<endl;
                    arq<<"potencia das ferramentas:   "<<ferramentasres<<"  watts"<<endl;
                    arq<<"potencia do escritorio:   "<<escritoriores<<"  watts"<<endl;
                    arq<<"potencia da cozinha:   "<<cozinhares<<"  watts"<<endl;            
                    arq<<"potencia do banheiro:   "<<banheiores<<"  watts"<<endl;
                    arq<<"potencia de outros:   "<<outrosres<<"  watts"<<endl;
                    arq<<"potencia da  iluminacao:   "<<iluminares<<"  watts"<<endl;
                    arq<<"potencia total do padrao:  "<<res<<"  watts"<<endl;
                    arq<<"-----------------------------------------------------"<<endl;


                    arq<<"dinjuntores:"<<endl;

                    arq<<"1 dinjunto primcipal:  "<<djprim<<"  amperes"<<endl;  
                    arq<<"1 dinjunto iluminacao:  "<<djilum<<"  ampres"<<endl;
                    arq<<"1 dinjunto da sala:   "<<djs<<"  amperes"<<endl;
                    arq<<"1 dinjunto do quartos:   "<<djq<<"  amperes"<<endl;
                    arq<<"1 dinjunto do quintal:   "<<djqui<<"  amperes"<<endl;
                    arq<<"1 dinjunto das ferramentas:   "<<djfer<<"  amperes"<<endl;
                    arq<<"1 dinjunto da lavadeiria:   "<<djl<<"  amperes"<<endl;
                    arq<<"1 dinjunto do escritorio:   "<<dje<<"  amperes"<<endl;
                    arq<<"1 dinjunto da cozinha:   "<<djc<<"  amperes"<<endl;
                    arq<<"1 dinjunto do banheiro:   "<<djb<<"  amperes"<<endl;
                    arq<<"1 dinjunto de outros:   "<<djo<<"  amperes"<<endl;

                    arq<<"-----------------------------------------------------"<<endl;

                    arq<<"fios:"<<endl;


                    arq<<"bitola de fios primcipal:  "<<fiop<<"  mm"<<endl; 

                    arq<<"bitola de fios da sala:  "<<fios<<"  mm"<<endl;
                    arq<<"bitola de fios dos quartos:  "<<fioq<<"  mm"<<endl;
                    arq<<"bitola de fios do quintal:  "<<fioquim<<"  mm"<<endl;
                    arq<<"bitola de fios da lavadeiria:   "<<fiol<<"  mm"<<endl;
                    arq<<"bitola de fios das ferramentas:   "<<fiofer<<"  mm"<<endl;
                    arq<<"bitola de fios do escritorio:   "<<fioe<<"  mm"<<endl;
                    arq<<"bitola de fios da cozinha:  "<<fioc<<"  mm"<<endl;
                    arq<<"bitola de fios d o banheiro:  "<<fiob<<"  mm"<<endl;
                    arq<<"bitola de fios da iluminacao:  "<<fioilu<<"  mm"<<endl;
                    arq<<"bitola de fios de outros:   "<<fioo<<"  mm"<<endl; 

                    
                    
                    
                    
                    
                    
                    
                        
                    
                    break;
                case 2:
                    arq<<"padrao bifasico"<<endl;

                    
                    arq<<"potencia da sala:   "<<salares<<"  watts"<<endl;
                    arq<<"potencia dos quartos:   "<<quartores<<"  watts"<<endl;
                    arq<<"potencia do quintal:   "<<quintalres<<"  watts"<<endl;
                    arq<<"potencia da lavadeiria:   "<<lavadeiriares<<"  watts"<<endl;
                    arq<<"potencia das ferramentas:   "<<ferramentasres<<"  watts"<<endl;
                    arq<<"potencia do escritorio:   "<<escritoriores<<"  watts"<<endl;
                    arq<<"potencia da cozinha:   "<<cozinhares<<"  watts"<<endl;            
                    arq<<"potencia do banheiro:   "<<banheiores<<"  watts"<<endl;
                    arq<<"potencia de outros:   "<<outrosres<<"  watts"<<endl;
                    arq<<"potencia da  iluminacao:   "<<iluminares<<"  watts"<<endl;
                    arq<<"potencia total do padrao:  "<<res<<"  watts"<<endl;
                    arq<<"-----------------------------------------------------"<<endl;


                    arq<<"dinjuntores:"<<endl;

                    arq<<"1 dinjunto primcipal:  "<<djprim<<"  amperes"<<endl;  
                    arq<<"1 dinjunto iluminacao:  "<<djilum<<"  ampres"<<endl;
                    arq<<"1 dinjunto da sala:   "<<djs<<"  amperes"<<endl;
                    arq<<"1 dinjunto do quartos:   "<<djq<<"  amperes"<<endl;
                    arq<<"1 dinjunto do quintal:   "<<djqui<<"  amperes"<<endl;
                    arq<<"1 dinjunto das ferramentas:   "<<djfer<<"  amperes"<<endl;
                    arq<<"1 dinjunto da lavadeiria:   "<<djl<<"  amperes"<<endl;
                    arq<<"1 dinjunto do escritorio:   "<<dje<<"  amperes"<<endl;
                    arq<<"1 dinjunto da cozinha:   "<<djc<<"  amperes"<<endl;
                    arq<<"1 dinjunto do banheiro:   "<<djb<<"  amperes"<<endl;
                    arq<<"1 dinjunto de outros:   "<<djo<<"  amperes"<<endl;

                    arq<<"-----------------------------------------------------"<<endl;

                    arq<<"fios:"<<endl;


                    arq<<"bitola de fios primcipal:  "<<fiop<<"  mm"<<endl; 

                    arq<<"bitola de fios da sala:  "<<fios<<"  mm"<<endl;
                    arq<<"bitola de fios dos quartos:  "<<fioq<<"  mm"<<endl;
                    arq<<"bitola de fios do quintal:  "<<fioquim<<"  mm"<<endl;
                    arq<<"bitola de fios da lavadeiria:   "<<fiol<<"  mm"<<endl;
                    arq<<"bitola de fios das ferramentas:   "<<fiofer<<"  mm"<<endl;
                    arq<<"bitola de fios do escritorio:   "<<fioe<<"  mm"<<endl;
                    arq<<"bitola de fios da cozinha:  "<<fioc<<"  mm"<<endl;
                    arq<<"bitola de fios d o banheiro:  "<<fiob<<"  mm"<<endl;
                    arq<<"bitola de fios da iluminacao:  "<<fioilu<<"  mm"<<endl;
                    arq<<"bitola de fios de outros:   "<<fioo<<"  mm"<<endl; 

                    
                    
                    
                    

                
                    
                    break;
                case 3:
                    arq<<"padrao trifasico"<<endl;

                    
                    arq<<"potencia da sala:   "<<salares<<"  watts"<<endl;
                    arq<<"potencia dos quartos:   "<<quartores<<"  watts"<<endl;
                    arq<<"potencia do quintal:   "<<quintalres<<"  watts"<<endl;
                    arq<<"potencia da lavadeiria:   "<<lavadeiriares<<"  watts"<<endl;
                    arq<<"potencia das ferramentas:   "<<ferramentasres<<"  watts"<<endl;
                    arq<<"potencia do escritorio:   "<<escritoriores<<"  watts"<<endl;
                    arq<<"potencia da cozinha:   "<<cozinhares<<"  watts"<<endl;            
                    arq<<"potencia do banheiro:   "<<banheiores<<"  watts"<<endl;
                    arq<<"potencia de outros:   "<<outrosres<<"  watts"<<endl;
                    arq<<"potencia da  iluminacao:   "<<iluminares<<"  watts"<<endl;
                    arq<<"potencia total do padrao:  "<<res<<"  watts"<<endl;
                    arq<<"-----------------------------------------------------"<<endl;


                    arq<<"dinjuntores:"<<endl;

                    arq<<"1 dinjunto primcipal:  "<<djprim<<"  amperes"<<endl;  
                    arq<<"1 dinjunto iluminacao:  "<<djilum<<"  ampres"<<endl;
                    arq<<"1 dinjunto da sala:   "<<djs<<"  amperes"<<endl;
                    arq<<"1 dinjunto do quartos:   "<<djq<<"  amperes"<<endl;
                    arq<<"1 dinjunto do quintal:   "<<djqui<<"  amperes"<<endl;
                    arq<<"1 dinjunto das ferramentas:   "<<djfer<<"  amperes"<<endl;
                    arq<<"1 dinjunto da lavadeiria:   "<<djl<<"  amperes"<<endl;
                    arq<<"1 dinjunto do escritorio:   "<<dje<<"  amperes"<<endl;
                    arq<<"1 dinjunto da cozinha:   "<<djc<<"  amperes"<<endl;
                    arq<<"1 dinjunto do banheiro:   "<<djb<<"  amperes"<<endl;
                    arq<<"1 dinjunto de outros:   "<<djo<<"  amperes"<<endl;

                    arq<<"-----------------------------------------------------"<<endl;

                    arq<<"fios:"<<endl;


                    arq<<"bitola de fios primcipal:  "<<fiop<<"  mm"<<endl; 

                    arq<<"bitola de fios da sala:  "<<fios<<"  mm"<<endl;
                    arq<<"bitola de fios dos quartos:  "<<fioq<<"  mm"<<endl;
                    arq<<"bitola de fios do quintal:  "<<fioquim<<"  mm"<<endl;
                    arq<<"bitola de fios da lavadeiria:   "<<fiol<<"  mm"<<endl;
                    arq<<"bitola de fios das ferramentas:   "<<fiofer<<"  mm"<<endl;
                    arq<<"bitola de fios do escritorio:   "<<fioe<<"  mm"<<endl;
                    arq<<"bitola de fios da cozinha:  "<<fioc<<"  mm"<<endl;
                    arq<<"bitola de fios d o banheiro:  "<<fiob<<"  mm"<<endl;
                    arq<<"bitola de fios da iluminacao:  "<<fioilu<<"  mm"<<endl;
                    arq<<"bitola de fios de outros:   "<<fioo<<"  mm"<<endl; 

                break;  
                    
                    
                    

            }
        
        
            
            break;arq.close();//fecha o arquivo   
        case 'c': 
            switch (padr){
                //ofstream arq;
                //arq1.open("calculo de watts.txt",ios::app);
                    



                case 1:

                    arq1<<"==================================================="<<endl;
                    arq1<<"==================================================="<<endl;
                    arq1<<"==================================================="<<endl;
                        
                        
                    arq1<<"padrao monofasico"<<endl;
                    arq1<<"potencia da sala:   "<<salares<<"  watts"<<endl;
                    arq1<<"potencia dos quartos:   "<<quartores<<"  watts"<<endl;
                    arq1<<"potencia do quintal:   "<<quintalres<<"  watts"<<endl;
                    arq1<<"potencia da lavadeiria:   "<<lavadeiriares<<"  watts"<<endl;
                    arq1<<"potencia das ferramentas:   "<<ferramentasres<<"  watts"<<endl;
                    arq1<<"potencia do escritorio:   "<<escritoriores<<"  watts"<<endl;
                    arq1<<"potencia da cozinha:   "<<cozinhares<<"  watts"<<endl;            
                    arq1<<"potencia do banheiro:   "<<banheiores<<"  watts"<<endl;
                    arq1<<"potencia de outros:   "<<outrosres<<"  watts"<<endl;
                    arq1<<"potencia da  iluminacao:   "<<iluminares<<"  watts"<<endl;
                    arq1<<"potencia total do padrao:  "<<res<<"  watts"<<endl;
                    arq1<<"-----------------------------------------------------"<<endl;


                    arq1<<"dinjuntores:"<<endl;

                    arq1<<"1 dinjunto primcipal:  "<<djprim<<"  amperes"<<endl;  
                    arq1<<"1 dinjunto iluminacao:  "<<djilum<<"  ampres"<<endl;
                    arq1<<"1 dinjunto da sala:   "<<djs<<"  amperes"<<endl;
                    arq1<<"1 dinjunto do quartos:   "<<djq<<"  amperes"<<endl;
                    arq1<<"1 dinjunto do quintal:   "<<djqui<<"  amperes"<<endl;
                    arq1<<"1 dinjunto das ferramentas:   "<<djfer<<"  amperes"<<endl;
                    arq1<<"1 dinjunto da lavadeiria:   "<<djl<<"  amperes"<<endl;
                    arq1<<"1 dinjunto do escritorio:   "<<dje<<"  amperes"<<endl;
                    arq1<<"1 dinjunto da cozinha:   "<<djc<<"  amperes"<<endl;
                    arq1<<"1 dinjunto do banheiro:   "<<djb<<"  amperes"<<endl;
                    arq1<<"1 dinjunto de outros:   "<<djo<<"  amperes"<<endl;

                    arq1<<"-----------------------------------------------------"<<endl;

                    arq1<<"fios:"<<endl;


                    arq1<<"bitola de fios primcipal:  "<<fiop<<"  mm"<<endl; 

                    arq1<<"bitola de fios da sala:  "<<fios<<"  mm"<<endl;
                    arq1<<"bitola de fios dos quartos:  "<<fioq<<"  mm"<<endl;
                    arq1<<"bitola de fios do quintal:  "<<fioquim<<"  mm"<<endl;
                    arq1<<"bitola de fios da lavadeiria:   "<<fiol<<"  mm"<<endl;
                    arq1<<"bitola de fios das ferramentas:   "<<fiofer<<"  mm"<<endl;
                    arq1<<"bitola de fios do escritorio:   "<<fioe<<"  mm"<<endl;
                    arq1<<"bitola de fios da cozinha:  "<<fioc<<"  mm"<<endl;
                    arq1<<"bitola de fios d o banheiro:  "<<fiob<<"  mm"<<endl;
                    arq1<<"bitola de fios da iluminacao:  "<<fioilu<<"  mm"<<endl;
                    arq1<<"bitola de fios de outros:   "<<fioo<<"  mm"<<endl; 
                    
                    break;
       
                case 2:
                    arq1<<"==================================================="<<endl;
                    arq1<<"==================================================="<<endl;
                    arq1<<"==================================================="<<endl;
                    arq1<<"padrao bifasico"<<endl;

                    arq1<<"potencia da sala:   "<<salares<<"  watts"<<endl;
                    arq1<<"potencia dos quartos:   "<<quartores<<"  watts"<<endl;
                    arq1<<"potencia do quintal:   "<<quintalres<<"  watts"<<endl;
                    arq1<<"potencia da lavadeiria:   "<<lavadeiriares<<"  watts"<<endl;
                    arq1<<"potencia das ferramentas:   "<<ferramentasres<<"  watts"<<endl;
                    arq1<<"potencia do escritorio:   "<<escritoriores<<"  watts"<<endl;
                    arq1<<"potencia da cozinha:   "<<cozinhares<<"  watts"<<endl;            
                    arq1<<"potencia do banheiro:   "<<banheiores<<"  watts"<<endl;
                    arq1<<"potencia de outros:   "<<outrosres<<"  watts"<<endl;
                    arq1<<"potencia da  iluminacao:   "<<iluminares<<"  watts"<<endl;
                    arq1<<"potencia total do padrao:  "<<res<<"  watts"<<endl;
                    arq1<<"-----------------------------------------------------"<<endl;


                    arq1<<"dinjuntores:"<<endl;

                    arq1<<"1 dinjunto primcipal:  "<<djprim<<"  amperes"<<endl;  
                    arq1<<"1 dinjunto iluminacao:  "<<djilum<<"  ampres"<<endl;
                    arq1<<"1 dinjunto da sala:   "<<djs<<"  amperes"<<endl;
                    arq1<<"1 dinjunto do quartos:   "<<djq<<"  amperes"<<endl;
                    arq1<<"1 dinjunto do quintal:   "<<djqui<<"  amperes"<<endl;
                    arq1<<"1 dinjunto das ferramentas:   "<<djfer<<"  amperes"<<endl;
                    arq1<<"1 dinjunto da lavadeiria:   "<<djl<<"  amperes"<<endl;
                    arq1<<"1 dinjunto do escritorio:   "<<dje<<"  amperes"<<endl;
                    arq1<<"1 dinjunto da cozinha:   "<<djc<<"  amperes"<<endl;
                    arq1<<"1 dinjunto do banheiro:   "<<djb<<"  amperes"<<endl;
                    arq1<<"1 dinjunto de outros:   "<<djo<<"  amperes"<<endl;

                    arq1<<"-----------------------------------------------------"<<endl;

                    arq1<<"fios:"<<endl;


                    arq1<<"bitola de fios primcipal:  "<<fiop<<"  mm"<<endl; 

                    arq1<<"bitola de fios da sala:  "<<fios<<"  mm"<<endl;
                    arq1<<"bitola de fios dos quartos:  "<<fioq<<"  mm"<<endl;
                    arq1<<"bitola de fios do quintal:  "<<fioquim<<"  mm"<<endl;
                    arq1<<"bitola de fios da lavadeiria:   "<<fiol<<"  mm"<<endl;
                    arq1<<"bitola de fios das ferramentas:   "<<fiofer<<"  mm"<<endl;
                    arq1<<"bitola de fios do escritorio:   "<<fioe<<"  mm"<<endl;
                    arq1<<"bitola de fios da cozinha:  "<<fioc<<"  mm"<<endl;
                    arq1<<"bitola de fios d o banheiro:  "<<fiob<<"  mm"<<endl;
                    arq1<<"bitola de fios da iluminacao:  "<<fioilu<<"  mm"<<endl;
                    arq1<<"bitola de fios de outros:   "<<fioo<<"  mm"<<endl;
                    
                    break;
                case 3:

                    arq1<<"==================================================="<<endl;
                    arq1<<"==================================================="<<endl;
                    arq1<<"==================================================="<<endl;
                    
                    arq1<<"padrao trifasico"<<endl;


                    arq1<<"potencia da sala:   "<<salares<<"  watts"<<endl;
                    arq1<<"potencia dos quartos:   "<<quartores<<"  watts"<<endl;
                    arq1<<"potencia do quintal:   "<<quintalres<<"  watts"<<endl;
                    arq1<<"potencia da lavadeiria:   "<<lavadeiriares<<"  watts"<<endl;
                    arq1<<"potencia das ferramentas:   "<<ferramentasres<<"  watts"<<endl;
                    arq1<<"potencia do escritorio:   "<<escritoriores<<"  watts"<<endl;
                    arq1<<"potencia da cozinha:   "<<cozinhares<<"  watts"<<endl;            
                    arq1<<"potencia do banheiro:   "<<banheiores<<"  watts"<<endl;
                    arq1<<"potencia de outros:   "<<outrosres<<"  watts"<<endl;
                    arq1<<"potencia da  iluminacao:   "<<iluminares<<"  watts"<<endl;
                    arq1<<"potencia total do padrao:  "<<res<<"  watts"<<endl;
                    arq1<<"-----------------------------------------------------"<<endl;


                    arq1<<"dinjuntores:"<<endl;

                    arq1<<"1 dinjunto primcipal:  "<<djprim<<"  amperes"<<endl;  
                    arq1<<"1 dinjunto iluminacao:  "<<djilum<<"  ampres"<<endl;
                    arq1<<"1 dinjunto da sala:   "<<djs<<"  amperes"<<endl;
                    arq1<<"1 dinjunto do quartos:   "<<djq<<"  amperes"<<endl;
                    arq1<<"1 dinjunto do quintal:   "<<djqui<<"  amperes"<<endl;
                    arq1<<"1 dinjunto das ferramentas:   "<<djfer<<"  amperes"<<endl;
                    arq1<<"1 dinjunto da lavadeiria:   "<<djl<<"  amperes"<<endl;
                    arq1<<"1 dinjunto do escritorio:   "<<dje<<"  amperes"<<endl;
                    arq1<<"1 dinjunto da cozinha:   "<<djc<<"  amperes"<<endl;
                    arq1<<"1 dinjunto do banheiro:   "<<djb<<"  amperes"<<endl;
                    arq1<<"1 dinjunto de outros:   "<<djo<<"  amperes"<<endl;

                    arq1<<"-----------------------------------------------------"<<endl;

                    arq1<<"fios:"<<endl;


                    arq1<<"bitola de fios primcipal:  "<<fiop<<"  mm"<<endl; 

                    arq1<<"bitola de fios da sala:  "<<fios<<"  mm"<<endl;
                    arq1<<"bitola de fios dos quartos:  "<<fioq<<"  mm"<<endl;
                    arq1<<"bitola de fios do quintal:  "<<fioquim<<"  mm"<<endl;
                    arq1<<"bitola de fios da lavadeiria:   "<<fiol<<"  mm"<<endl;
                    arq1<<"bitola de fios das ferramentas:   "<<fiofer<<"  mm"<<endl;
                    arq1<<"bitola de fios do escritorio:   "<<fioe<<"  mm"<<endl;
                    arq1<<"bitola de fios da cozinha:  "<<fioc<<"  mm"<<endl;
                    arq1<<"bitola de fios d o banheiro:  "<<fiob<<"  mm"<<endl;
                    arq1<<"bitola de fios da iluminacao:  "<<fioilu<<"  mm"<<endl;
                    arq1<<"bitola de fios de outros:   "<<fioo<<"  mm"<<endl;
                    
                    break; 
                        
                        
                        

                }
        break;arq1.close();//fecha o arquivo 

        
    }
        
    
        
        
 

   return 0;
     
     
}










