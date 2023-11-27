/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

package pe.edu.pucp.rmi;

import java.rmi.Naming;
import java.util.ArrayList;
import pe.edu.pucp.eventsoft.interfaces.EspecialidadDAO;
import pe.edu.pucp.eventsoft.model.Especialidad;
/**
 *
 * Author: Jeremy Aldama (20206228)
 */
public class RMIClient {
    private static String IP = "127.0.0.1";
    private static String puerto = "1234";
    public static void main(String[] args){
        try{
            EspecialidadDAO daoEspecialidad = (EspecialidadDAO) Naming.lookup("//"+ IP + ":" + puerto +"/" + "daoEspecialidad");   
            ArrayList<Especialidad> especialidades = daoEspecialidad.listarTodas();
            for(Especialidad a : especialidades){
                System.out.println(a.getIdEspecialidad() + ". "+ 
                        a.getNombre());
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
    }
}
