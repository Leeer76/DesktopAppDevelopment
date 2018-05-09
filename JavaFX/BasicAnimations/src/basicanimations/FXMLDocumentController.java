/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package basicanimations;

import java.awt.Panel;
import java.net.URL;
import java.util.ResourceBundle;
import javafx.animation.RotateTransition;
import javafx.animation.ScaleTransition;
import javafx.animation.TranslateTransition;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.Initializable;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.layout.Pane;
import javafx.util.Duration;

/**
 *
 * @author el51909
 */
public class FXMLDocumentController implements Initializable {
    
    @FXML private Button rightEyeBall;
    @FXML private Button leftEyeball;
    @FXML private Button rightPup;
    @FXML private Button leftPup;
    @FXML private Label outPut;
    @FXML private Button rightEye;
    @FXML private Button leftEye;
    @FXML private Pane eyeBrowLt;
    @FXML private Pane eyeBrowRt;
    
    @FXML
    private void handleButtonAction(ActionEvent event) {
        System.out.println("You clicked me!");
        outPut.setText("What are you doing Here!!!");
    }
    
    @Override
    public void initialize(URL url, ResourceBundle rb) {
        // 
        TranslateTransition rtEye = new TranslateTransition();
        rtEye.setDuration(Duration.seconds(3));
        rtEye.setNode(rightEyeBall);
        
        TranslateTransition ltEye = new TranslateTransition();
        ltEye.setDuration(Duration.seconds(3));
        ltEye.setNode(leftEyeball);
        
        
        TranslateTransition ltPup = new TranslateTransition();
        ltPup.setDuration(Duration.seconds(3));
        ltPup.setNode(leftPup);
        
        TranslateTransition rtPup = new TranslateTransition();
        rtPup.setDuration(Duration.seconds(3));
        rtPup.setNode(rightPup);
        
        TranslateTransition rtPupD = new TranslateTransition();
        rtPupD.setDuration(Duration.seconds(3));
        rtPupD.setNode(rightPup);
        
        ScaleTransition rtEyeScale = new ScaleTransition();
        rtEyeScale.setDuration(Duration.seconds(1));
        rtEyeScale.setNode(rightPup);
        
        ScaleTransition ltEyeScale = new ScaleTransition();
        ltEyeScale.setDuration(Duration.seconds(1));
        ltEyeScale.setNode(leftPup);
        
        ScaleTransition ltEyeBallScale = new ScaleTransition();
        ltEyeBallScale.setDuration(Duration.seconds(.9));
        ltEyeBallScale.setNode(leftEyeball);
        
        ScaleTransition rtEyeBallScale = new ScaleTransition();
        rtEyeBallScale.setDuration(Duration.seconds(.9));
        rtEyeBallScale.setNode(rightEyeBall);
        
        ScaleTransition rtBallScale = new ScaleTransition();
        rtBallScale.setDuration(Duration.seconds(2));
        rtBallScale.setNode(rightEye);
        
        ScaleTransition ltBallScale = new ScaleTransition();
        ltBallScale.setDuration(Duration.seconds(2));
        ltBallScale.setNode(leftEye);
        
        ltBallScale.setToY(.7);
        rtBallScale.setToY(.7);
        
        rtEyeScale.setToY(1.2);
        rtEyeScale.setToX(1.2);
        
        ltEyeScale.setToY(1.2);
        ltEyeScale.setToX(1.2);
        
        rtEyeBallScale.setToY(1.25);
        rtEyeBallScale.setToX(1.25);
        
        ltEyeBallScale.setToY(1.25);
        ltEyeBallScale.setToX(1.25);
        
        rtEye.setByY(0);
        rtEye.setToX(240);
        
        rtPup.setByY(0);
        rtPup.setToX(240);
        
        ltEye.setByY(0);
        ltEye.setToX(240);
        
        ltPup.setByY(0);
        ltPup.setToX(240);
        
        
        rtEyeScale.setAutoReverse(true);
        ltEyeScale.setAutoReverse(true);
        rtEyeScale.setCycleCount(ScaleTransition.INDEFINITE);
        ltEyeScale.setCycleCount(ScaleTransition.INDEFINITE);
        rtBallScale.setAutoReverse(true);
        rtBallScale.setCycleCount(ScaleTransition.INDEFINITE);
        ltBallScale.setAutoReverse(true);
        ltBallScale.setCycleCount(ScaleTransition.INDEFINITE);
        
        rtEyeBallScale.setAutoReverse(true);
        ltEyeBallScale.setAutoReverse(true);
        rtEyeBallScale.setCycleCount(ScaleTransition.INDEFINITE);
        ltEyeBallScale.setCycleCount(ScaleTransition.INDEFINITE);
        
        rtEye.setAutoReverse(true);
        rtPup.setAutoReverse(true);
        ltEye.setAutoReverse(true);
        ltPup.setAutoReverse(true);
        rtEye.setCycleCount(TranslateTransition.INDEFINITE);
        rtPup.setCycleCount(TranslateTransition.INDEFINITE);
        ltEye.setCycleCount(TranslateTransition.INDEFINITE);
        ltPup.setCycleCount(TranslateTransition.INDEFINITE);
        
        
        RotateTransition rtEyeRot = new RotateTransition();
        rtEyeRot.setDuration(Duration.seconds(1));
        rtEyeRot.setNode(rightEye); 
        rtEyeRot.setByAngle(360);
        
        rtEyeRot.setAutoReverse(true);
        rtEyeRot.setCycleCount(RotateTransition.INDEFINITE);
        
        RotateTransition ltEyeRot = new RotateTransition();
        ltEyeRot.setDuration(Duration.seconds(2));
        ltEyeRot.setNode(leftEye); 
        ltEyeRot.setByAngle(360);
        
        ltEyeRot.setAutoReverse(true);
        ltEyeRot.setCycleCount(RotateTransition.INDEFINITE);
        
        RotateTransition ltBrow = new RotateTransition();
        ltBrow.setDuration(Duration.seconds(1));
        ltBrow.setNode(eyeBrowLt);
        ltBrow.setByAngle(30);
        
        ltBrow.setAutoReverse(true);
        ltBrow.setCycleCount(RotateTransition.INDEFINITE);
        
        RotateTransition rtBrow = new RotateTransition();
        rtBrow.setDuration(Duration.seconds(1));
        rtBrow.setNode(eyeBrowRt);
        rtBrow.setByAngle(-30);
        
        rtBrow.setAutoReverse(true);
        rtBrow.setCycleCount(RotateTransition.INDEFINITE);
        
        rtBrow.play();
        ltBrow.play();
        rtEyeRot.play();
        ltEyeRot.play();
        rtBallScale.play();
        ltBallScale.play();
        ltEyeScale.play();
        rtEyeBallScale.play();
        ltEyeBallScale.play();
        rtEyeScale.play();
        rtEye.play();
        rtPup.play();
        ltEye.play();
        ltPup.play();
    }    
    
}
