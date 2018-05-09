/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package morejavafxstyling;

import java.net.URL;
import java.util.ResourceBundle;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.Initializable;
import javafx.scene.control.Label;
import javafx.scene.layout.Pane;

/**
 *
 * @author el51909
 */
public class FXMLDocumentController implements Initializable {
    
    @FXML private Label outPutLbl;
    
    @FXML
    private void MouthButton(ActionEvent event) {
        outPutLbl.setText("Hello Kiddies!");
    }
    @FXML
    private void rightEyeButton(ActionEvent event) {
        outPutLbl.setText("I've Been Watching You!");
    }
    @FXML
    private void leftEyeButton(ActionEvent event) {
        outPutLbl.setText("I Smell of Sadness and Gin!");
    }
    
    @Override
    public void initialize(URL url, ResourceBundle rb) {
        // TODO
    }    
    
}
