#version 330 core
in vec4 FragPos;

uniform vec3 lightPos;
uniform float far_plane;

void main()
{
    float lightDistance = length(FragPos.xyz - lightPos);
    // mappa in un range di [0,1] dividendo con far_plane
    lightDistance = lightDistance / far_plane;
    
    gl_FragDepth = lightDistance;
}