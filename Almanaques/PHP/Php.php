<?php

    // Para mandar errores (en mensaje) posibles
    init_set('display_errors', 1);
    init_set('display_startup_errors', 1);
    error_reporting(E_ALL);

    // Subir imagen (codificada en String)
    $ruta = "imagenes";
    $fi = fopen($ruta.'/'.$_POST['imgNom'],"a");
    fclose($fi);
  
    if(file_exists($ruta.'/'.$_POST['imgNom']))
    {
      $abrir = fopen($ruta.'/'.$_POST['imgNom'],'w');
      fwrite($abrir, base64_decode($_POST['imgBase']));
    }

    // Subir imagen
    $upload = 'err';
    if (!empty($_FILES['file'])) {
          $targetDir = "uploads/";
          $allowTypes = array('pdf', 'doc', 'docx', 'jpg', 'png', 'jpeg', 'gif');
          $fileName = basename($_FILES['file']['name']);
          $targetFilePath = $targetDir . $fileName;
          $fileType = pathinfo($targetFilePath, PATHINFO_EXTENSION);
          if (in_array($fileType, $allowTypes)) {
                if (move_uploaded_file($_FILES['file']['tmp_name'], $targetFilePath)) {
                      $upload = 'ok';
                }
          }
    }
    echo $upload; 
?>