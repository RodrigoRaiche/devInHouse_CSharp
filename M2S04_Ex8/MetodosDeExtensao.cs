namespace M2S04_Ex8;
public static class MetodosDeExtensao{

    public static string traduzBolean(this bool valor){
        return valor ? "Verdadeiro" : "Falso";
    }

    public static int multiplica(this int valorInt, int multi){
        return valorInt * multi;
    }
}