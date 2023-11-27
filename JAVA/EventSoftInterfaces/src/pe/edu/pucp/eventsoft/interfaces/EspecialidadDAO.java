/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Interface.java to edit this template
 */
package pe.edu.pucp.eventsoft.interfaces;

import java.rmi.Remote;
import java.rmi.RemoteException;
import java.util.ArrayList;
import pe.edu.pucp.eventsoft.model.Especialidad;

/**
 *
 * @author Danie
 */
public interface EspecialidadDAO extends Remote {
    ArrayList<Especialidad> listarTodas() throws RemoteException;
}
