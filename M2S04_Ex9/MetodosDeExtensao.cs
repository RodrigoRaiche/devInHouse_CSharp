namespace M2S04_Ex9;
public static class MetodosDeExtensao{

    public static string traduzBolean(this bool valor){
        return valor ? "Verdadeiro" : "Falso";
    }

    public static int multiplica(this int valorInt, int multi){
        return valorInt * multi;
    }

    public static double multiplica(this int valorInt, double multi){
        return valorInt * multi;
    }

    public static double multiplica(this int valorInt, double multi, double multi2){
        return valorInt * multi * multi2;
    }

    public static double multiplica(this int valorInt, double multi, double multi2, double multi3 = 1, double multi4 = 1){
        return valorInt * multi * multi2 * multi3 * multi4;
    }


}

  