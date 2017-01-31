var sys = arbor.ParticleSystem(1000, 400, 1);
sys.parameters({ gravity: true });
sys.renderer = Renderer("#viewport");
var animals = sys.addNode('Animals', { 'color': 'red', 'shape': 'dot', 'label': 'Animals' });