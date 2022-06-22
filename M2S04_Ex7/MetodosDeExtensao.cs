namespace M2S04_Ex7;
public static class MetodosDeExtensao{

    public static string traduzBolean(this bool valor){
        return valor ? "Verdadeiro" : "Falso";
    }
}