#version 330 core
out vec4 FragColor;
out vec4 FragColor2;
in vec3 ourColor;
in vec2 TexCoord;
//in vec2 TexCoord2;

//texture samplers
uniform sampler2D texture1;
uniform sampler2D texture2;
uniform int type;

void main()
{
	//linearly interpolate between both textures (80% container, 20% awesomeface)
	//FragColor = mix(texture(texture2, TexCoord), texture(texture1, TexCoord), 0.3);
	if(0==type){
		FragColor = texture(texture1, TexCoord);
	}else{
		FragColor = texture(texture2, TexCoord);
	}
}