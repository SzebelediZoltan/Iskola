import * as THREE from 'three';
import {scene} from './script.js';

const boxGeometry = new THREE.BoxGeometry(5,5,5);
const boxMaterial = new THREE.MeshBasicMaterial({color: "red"});
const box = new THREE.Mesh(boxGeometry, boxMaterial);
scene.add(box);

const sphereGeometry = new THREE.SphereGeometry(2.5,20,20);
const sphereMaterial = new THREE.MeshBasicMaterial({
//const sphereMaterial = new THREE.MeshLambertMaterial({
    color: "blue"
    //wireframe: true
});
const sphere = new THREE.Mesh(sphereGeometry,sphereMaterial);
// sphere.position.x = -10;
// sphere.position.y = 10;
sphere.position.set(2.5,0,0);
scene.add(sphere);



const sphereGeometry2 = new THREE.SphereGeometry(2.5,20,20);
const sphereMaterial2 = new THREE.MeshBasicMaterial({
    color: "blue"
});
const sphere2 = new THREE.Mesh(sphereGeometry2,sphereMaterial2);
sphere2.position.set(-2.5,0,0);
scene.add(sphere2);


const sphereGeometry3 = new THREE.SphereGeometry(2.5,20,20);
const sphereMaterial3 = new THREE.MeshBasicMaterial({
    color: "blue"
});
const sphere3 = new THREE.Mesh(sphereGeometry3,sphereMaterial3);
sphere3.position.set(0,2.5,0);
scene.add(sphere3);


const sphereGeometry4 = new THREE.SphereGeometry(2.5,20,20);
const sphereMaterial4 = new THREE.MeshBasicMaterial({
    color: "blue"
});
const sphere4 = new THREE.Mesh(sphereGeometry4,sphereMaterial4);
sphere4.position.set(0,-2.5,0);
scene.add(sphere4);

