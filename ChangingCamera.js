//Tia Istianingsih Sistem Informasi Universitas Gunadarma
//email: tiaistianingsih@student.gunadarma.ac.id
//http://1A114743.student.gunadarma.ac.id
//http://www.gunadarma.ac.id
//Dosen Pembimbing : Dr.M Akbar Marwan, ST., MMSI

#pragma strict

var cam1 : Camera;
var cam2 : Camera;

function Start() {
cam1.enabled = true;
cam2.enabled = false;
}

function Update() {

if(Input.GetKeyDown(KeyCode.F)) {
cam1.enabled = !cam1.enabled;
cam2.enabled = !cam2.enabled;
}
}
