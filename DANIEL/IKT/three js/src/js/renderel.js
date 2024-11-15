import {renderer, scene, camera} from './script.js';
import {sphere} from './fenyek.js';

let step = 0;

function animate(){

    step += 0.07;
    sphere.position.y = 10* Math.abs(Math.sin(step));
    renderer.render(scene,camera);
}
renderer.setAnimationLoop(animate);