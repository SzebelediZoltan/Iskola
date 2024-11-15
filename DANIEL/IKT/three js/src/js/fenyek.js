import * as THREE from 'three';
import {scene} from './script.js';


const sphereGeometry = new THREE.SphereGeometry(2,20,20);
const sphereMaterial = new THREE.MeshStandardMaterial({
    color: 0x0000FF,
    wireframe: false
});
export const sphere = new THREE.Mesh(sphereGeometry,sphereMaterial);
sphere.position.set(-10, 10, 0);
sphere.castShadow = true;
scene.add(sphere);

const directionalLight = new THREE.DirectionalLight("white", 10);
directionalLight.position.set(-20,20,0);
directionalLight.castShadow = true;
scene.add(directionalLight);

const dLightHelper = new THREE.DirectionalLightHelper(directionalLight, 5);
scene.add(dLightHelper);

