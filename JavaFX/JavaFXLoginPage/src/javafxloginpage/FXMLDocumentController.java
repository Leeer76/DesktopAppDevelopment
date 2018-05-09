/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package javafxloginpage;

import java.net.URL;
import java.util.ResourceBundle;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.Initializable;
import javafx.scene.control.Label;
import javafx.scene.control.TextField;

/**
 *
 * @author el51909
 */
public class FXMLDocumentController implements Initializable {
    
    @FXML private Label loginMsg;
    @FXML private TextField passTxt;
    @FXML private TextField userTxt;
    
    
    @FXML
    private void loginBtn(ActionEvent event) {
        if(passTxt.getText().equals("password123") && userTxt.getText().equals("root")){
            loginMsg.setText("Login Successful");
        } else {
            loginMsg.setText("**Unsuccessful attempt to login**");
        }
    }
    
    @Override
    public void initialize(URL url, ResourceBundle rb) {
        // TODO
    }    
    
}
