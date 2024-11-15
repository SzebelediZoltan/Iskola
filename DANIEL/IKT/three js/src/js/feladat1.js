import * as THREE from 'three';
import {scene} from './script.js';

const boxGeometry = new THREE.BoxGeometry(5,5,5);
const boxMaterial = new THREE.MeshBasicMaterial({color: "red"});
const box = new THREE.Mesh(boxGeometry, boxMaterial);
scene.add(box);

const spheres = [
    {
        x: 2.5,
        y: 0,
        z: 0,
        r: 2.5
    },
    {
        x: -2.5,
        y: 0,
        z: 0,
        r: 2.5
    },
    {
        x: 0,
        y: 2.5,
        z: 0,
        r: 2.5
    },
    {
        x: 0,
        y: -2.5,
        z: 0,
        r: 2.5
    }
]

function Spheres(){
    for(let s of spheres)
    {
        const sphereGeometry = new THREE.SphereGeometry(s.r,20,20);
        const sphereMaterial = new THREE.MeshBasicMaterial({
            color: "blue"
        });
        const sphere = new THREE.Mesh(sphereGeometry,sphereMaterial);
        sphere.position.set(s.x,s.y,s.z);
        scene.add(sphere);
    }
}

Spheres();




