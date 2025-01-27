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
const planeMatrial = new THREE.MeshStandardMaterial({color: "darkgrey"});
const plane = new THREE.Mesh(planeGeometry, planeMatrial);
plane.receiveShadow = true
plane.rotation.x = -0.5*Math.PI;

const light = new THREE.PointLight( 0xffffff, 1, 100 );
light.position.set( 0, 10, 4 );
light.castShadow = true; // default false
scene.add( light );

const helper = new THREE.CameraHelper( light.shadow.camera );
scene.add( helper );

scene.add(plane);
function bastyakHozzadasa() {
    for (let i = 0; i < 4; i++) {
        const bastyaGeometry = new THREE.CylinderGeometry(1.5, 1.5, 16, 32)
        const bastyaMaterial = new THREE.MeshStandardMaterial({color: "grey"})
        const bastya = new THREE.Mesh(bastyaGeometry, bastyaMaterial)
        bastya.castShadow = true
        bastya.receiveShadow = true
        
        const edges = new THREE.EdgesGeometry(bastyaGeometry)
        const line = new THREE.LineSegments(edges, new THREE.LineBasicMaterial({color: "white"}))
        
        const group = new THREE.Group()
        group.add(bastya)
        group.add(line)
        
        bastya.position.set(16.5, 8, 16.5)
        line.position.set(16.5,8,16.5)
        
        group.rotation.y = Math.PI * (0.5 * i)
        scene.add(group)
        
    }
}

function falakHozzadasa() {
    for (let i = 0; i < 4; i++) {
        const falGeometry = new THREE.BoxGeometry(30, 10, 2)
        const falMaterial = new THREE.MeshStandardMaterial({color: grey})
        const fal = new THREE.Mesh(falGeometry, falMaterial)
        fal.castShadow = true
        fal.receiveShadow = true
        
        const edges = new THREE.EdgesGeometry( falGeometry ); 
        const line = new THREE.LineSegments(edges, new THREE.LineBasicMaterial( { color: "white" } ) )
        
        line.position.set(0 , 5, 16)
        fal.position.set(0, 5, 16)
        
        const group = new THREE.Group()
        group.add(fal)
        group.add(line)
        
        group.rotation.y = Math.PI * (0.5 * i)
        scene.add(group)
    }
}

function tetoHozzadasa() {
    for (let i = 0; i < 4; i++) {
        const tetoGeometry = new THREE.ConeGeometry(3, 5, 32)
        const tetoMaterial = new THREE.MeshStandardMaterial({color: "lightgrey"})
        const teto = new THREE.Mesh(tetoGeometry, tetoMaterial)
        teto.castShadow = true
        teto.receiveShadow = true
        
        const edges = new THREE.EdgesGeometry( tetoGeometry ); 
        const line = new THREE.LineSegments(edges, new THREE.LineBasicMaterial( { color: "white" } ) )
        
        const group = new THREE.Group()
        group.add(teto)
        group.add(line)
        
        teto.position.set(16.5, 18, 16.5)
        line.position.set(16.5, 18, 16.5)
    
        group.rotation.y = Math.PI * (0.5 * i)
    
        scene.add(group)
    }
}

tetoHozzadasa()
bastyakHozzadasa()
falakHozzadasa()


function animate(){
    renderer.render(scene,camera);
}
renderer.setAnimationLoop(animate);
