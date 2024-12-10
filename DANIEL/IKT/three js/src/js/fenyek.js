import * as THREE from 'three';
import {scene} from './script.js';

import kep1 from "./x0nwc7plbrs71.jpg"


const sphereGeometry = new THREE.SphereGeometry(2,20,20);
const sphereMaterial = new THREE.MeshStandardMaterial({
    color: 0x0000FF,
    wireframe: false
});
export const sphere = new THREE.Mesh(sphereGeometry,sphereMaterial);
sphere.position.set(0, 5, 0);
sphere.castShadow = true;
scene.add(sphere);

// const directionalLight = new THREE.DirectionalLight(0xFFFFFF, 5);
// directionalLight.position.set(-20,20,0);
// directionalLight.castShadow = true;
// scene.add(directionalLight);

// const dLightHelper = new THREE.DirectionalLightHelper(directionalLight, 5);
// scene.add(dLightHelper);

const spotLight = new THREE.SpotLight(0xffffff, 30, 50, 1, 1, 0.5)
spotLight.position.set(0, 30, 0)
spotLight.shadow.focus = 0.3
spotLight.castShadow = true
scene.add(spotLight)

const spotLightHelper = new THREE.SpotLightHelper(spotLight, 0xffffff)
scene.add(spotLightHelper)


const textureLoader = new THREE.TextureLoader();
scene.background = textureLoader.load(kep1)