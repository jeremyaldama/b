package pe.edu.pucp.eventsoft.interfaces;


import java.rmi.Remote;
import java.rmi.RemoteException;
import java.util.ArrayList;
import pe.edu.pucp.eventsoft.model.Actividad;

/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Interface.java to edit this template
 */

/**
 *
 * @author Danie
 */
public interface ActividadDAO extends Remote {
    ArrayList<Actividad> listarPorIdEvento(int idEvento) throws RemoteException;
}
