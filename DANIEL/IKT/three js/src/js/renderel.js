import {renderer, scene, camera} from './script.js';
import {sphere} from './fenyek.js';

let step = 0;

function animate(){

    step += 0.01;
    sphere.position.y = 7* Math.abs(Math.sin(step));
    renderer.render(scene,camera);
}
renderer.setAnimationLoop(animate);