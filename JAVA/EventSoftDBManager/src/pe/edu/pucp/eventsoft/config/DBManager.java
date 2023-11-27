package pe.edu.pucp.eventsoft.config;

import java.sql.Connection;
import java.sql.DriverManager;

/*
    Coloque su nombre completo y código:
    
*/
public class DBManager {
    private static DBManager dbManager;
    private String url = "jdbc:mysql://" + 
            "lp2-2023-2.c1fmg5ipekwi.us-east-1.rds.amazonaws.com" + 
            ":3306/prueba?useSSL=false";
    private String user = "admin";
    private String password = "lp2-2023-2";
    private Connection con;
    
    private synchronized static void createInstance(){
        if(dbManager == null){
            dbManager = new DBManager();
        }
    }
    
    public Connection getConnection(){
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(url,user,password);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return con;
    }
    
    public static DBManager getInstance(){
        if(dbManager == null){
            createInstance();
        }
        return dbManager;
    }
}
