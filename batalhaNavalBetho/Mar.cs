using System;
using System.IO;

class Mar {
    int[,] array = new int[8, 8];
    
    public int acertou;
    public int jogador = 1;
    
    public void limpaTela()
    {
        Console.Clear();
    }
    
    public void inseriCoordenada()
    {
   
        Console.Write("Jogador 1\n");
        Console.Write(" ► ");
        String text_j1 = Console.ReadLine();
        Console.Write("");
        
        
        for (int i = 1; i <= 3; i++)
        {
            Console.Write("Localização " + i + " de Jogador " + text_j1 + "\n");
            Console.Write("Coordenadas - use números entre 0 e 7\n");
            Console.Write("Longitude  : ");
            int locX = Convert.ToInt32( Console.ReadLine() );
           
            Console.Write("Latitude   : ");
            int locY = Convert.ToInt32( Console.ReadLine() );
           
            if ( verTamanhoXY(locX,locY) ){   
                
                if ( localizaNavio(1,locX,locY) ){
                    Console.Write("Coordenada OK \n");
                } else {
                    Console.Write("Erro Coordenada, tente outra coordenada \n");
                    i -= 1 ;
                }
            } else {
                 Console.Write("Ei mané !! Coordenada maior que o tamanho do Mar, tente outra coordenada \n");
                 i -= 1 ;
            }
            // limpaTela();
        }
        
        limpaTela();
        
        Console.Write("____________________________________________________\n");
        Console.Write("Jogador 2\n");
        String text_j2 = Console.ReadLine();
        Console.Write("Enter com suas coordenadas, voce tem direito a 3 navios \n");
        
        for (int i = 1; i <= 3; i++)
        {
            Console.Write("Localização " + i + " de Jogador " + text_j1 + "\n");
            Console.Write("Coordenadas - use números entre 0 e 7\n");
            Console.Write("Longitude  : ");
            int locX = Convert.ToInt32( Console.ReadLine() );
           
            Console.Write("Latitude   : ");
            int locY = Convert.ToInt32( Console.ReadLine() );
           
            if ( verTamanhoXY(locX,locY) ){   
                
                if ( localizaNavio(2,locX,locY) ){
                    Console.Write("Coordenada OK \n");
                } else {
                    Console.Write("Erro Coordenada, tente outra coordenada \n");
                    i -= 1 ;
                }
            } else {
                 Console.Write("Ei mané !! Coordenada maior que o tamanho do Mar, tente outra coordenada \n");
                 i -= 1 ;
            }
            // limpaTela();
        }
        
        limpaTela();
        atiraNavio(0,0);
        
       
    }
    
    public bool verTamanhoXY(int locX, int locY)
    {
        if ( locX > 7 || locY > 7 ){
            return false;
        }
        
        return true;
    
    }
    
    public bool localizaNavio(int j,int locX,int locY)
    {
        if ( verLocal(locX,locY ) ) {
            Console.Write("vazio \n");
            array[locX,locY] = j;
            return true;
        } else {
            Console.Write("ocupado \n");
            return false;
        }
            
    }
    
    public void mostraMar()
    {
     
     for (int i = 0; i < 8 ; i++){
        for (int e = 0; e < 8 ; e++){
            Console.Write(array[i,e] );
        }
         Console.Write("\n");
     }
     
    }
    
    
    public bool verLocal(int locX,int locY){
        
        if ( array[locX,locY] == 0){
            return true;    
        } else {
            return false;    
        }
        
    }
    
    public string atiraNavio(int locX,int locY){
        acertou ++;
    
        return "voce gahou";
        
    }
    
    public void inseriInf(){
        Console.Write("Instruções:\n");
        Console.Write("02 Jogadores, tem direito a 3 navios, usando coordenadas em matriz de 8x8,\n");
        Console.Write("cada usuário alocará seus navios usando eixos de latitude e longitude\n");
        Console.Write("com numeração de 0 a 7\n");
        Console.Write("após a alocação dos navios, os jogadores começam a jogar suas minas, com\n");
        Console.Write("tiros alternados entre jogadores, até a destruição do primeiro oponente, \n");
        Console.Write("finalizando com o Vencedor o que permanecer com navio.\n");
    }
    
     public void menu(){
        Console.Write("╔═════════════════════════════════════════════════════════╗\n");
        Console.Write("║ Bem vindo a Batalha naval - ver 0.00001                 ║\n");
        Console.Write("╚═════════════════════════════════════════════════════════╝\n");
        Console.Write("╔═════════════════════════════════════════════════════════╗\n");
        Console.Write("║ Menu                                                    ║\n");
        Console.Write("╠═════════════════════════════════════════════════════════╣\n");
        Console.Write("║ (1) Instruções do Jogo                                  ║\n");
        Console.Write("║ (2) Jogar                                               ║\n");
        Console.Write("║ (3) Sobre                                               ║\n");
        Console.Write("╚═════════════════════════════════════════════════════════╝\n");
        String text_op = Console.ReadLine();
        switch (text_op)
        {
            case "1":
            limapaTela();
            

        }

    }
   
        
        
}