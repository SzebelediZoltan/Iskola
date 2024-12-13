import * as THREE from 'three';
import { OrbitControls } from 'three/examples/jsm/controls/OrbitControls.js';

export const renderer = new THREE.WebGLRenderer();

renderer.shadowMap.enabled = true;

renderer.setSize(window.innerWidth,window.innerHeight);

document.body.appendChild(renderer.domElement);

export const scene = new THREE.Scene();
scene.background = new THREE.Color(0x9bf598)

const grey = new THREE.Color(0xc9c9c9)

export const camera = new THREE.PerspectiveCamera(
    75,
    window.innerWidth/window.innerHeight,
    0.1,
    1000
);
const orbit = new OrbitControls(camera, renderer.domElement);

camera.position.set(1,1,30);
orbit.update();

const planeGeometry = new THREE.PlaneGeometry(30,30);
const planeMatrial = new THREE.MeshBasicMaterial({color: "darkgrey"});
const plane = new THREE.Mesh(planeGeometry, planeMatrial);
plane.rotation.x = -0.5*Math.PI;

scene.add(plane);

function falakHozzadasa() {
    for (let i = 0; i < 4; i++) {
        const falGeometry = new THREE.BoxGeometry(30, 10, 2)
        const falMaterial = new THREE.MeshBasicMaterial({color: grey})
        const fal = new THREE.Mesh(falGeometry, falMaterial)
        fal.position.set(0, 5, 14)
        scene.add(fal)
    }
}

falakHozzadasa()


function animate(){
    renderer.render(scene,camera);
}
renderer.setAnimationLoop(animate);
