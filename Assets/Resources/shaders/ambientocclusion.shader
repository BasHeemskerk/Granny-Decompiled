Shader "Hidden/Post FX/Ambient Occlusion" {
	Properties {
	}
	SubShader {
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 52070
			Program "vp" {
				SubProgram "d3d11 " {
					Keywords { "FOG_OFF" }
					"vs_4_0
					
					#version 330
					#extension GL_ARB_explicit_attrib_location : require
					#extension GL_ARB_explicit_uniform_location : require
					
					#define HLSLCC_ENABLE_UNIFORM_BUFFERS 1
					#if HLSLCC_ENABLE_UNIFORM_BUFFERS
					#define UNITY_UNIFORM
					#else
					#define UNITY_UNIFORM uniform
					#endif
					#define UNITY_SUPPORTS_UNIFORM_LOCATION 1
					#if UNITY_SUPPORTS_UNIFORM_LOCATION
					#define UNITY_LOCATION(x) layout(location = x)
					#define UNITY_BINDING(x) layout(binding = x, std140)
					#else
					#define UNITY_LOCATION(x)
					#define UNITY_BINDING(x) layout(std140)
					#endif
					layout(std140) uniform VGlobals {
						vec4 unused_0_0[2];
						vec4 _MainTex_TexelSize;
						vec4 unused_0_2[6];
					};
					layout(std140) uniform UnityPerDraw {
						mat4x4 unity_ObjectToWorld;
						vec4 unused_1_1[6];
					};
					layout(std140) uniform UnityPerFrame {
						vec4 unused_2_0[17];
						mat4x4 unity_MatrixVP;
						vec4 unused_2_2[2];
					};
					in  vec4 in_POSITION0;
					in  vec4 in_TEXCOORD0;
					out vec2 vs_TEXCOORD0;
					 vec4 phase0_Output0_1;
					out vec2 vs_TEXCOORD1;
					out vec2 vs_TEXCOORD2;
					vec4 u_xlat0;
					bool u_xlatb0;
					vec4 u_xlat1;
					float u_xlat2;
					void main()
					{
					    u_xlat0 = in_POSITION0.yyyy * unity_ObjectToWorld[1];
					    u_xlat0 = unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    u_xlat0 = u_xlat0 + unity_ObjectToWorld[3];
					    u_xlat1 = u_xlat0.yyyy * unity_MatrixVP[1];
					    u_xlat1 = unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
					    u_xlat1 = unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
					    gl_Position = unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
					    u_xlatb0 = _MainTex_TexelSize.y<0.0;
					    u_xlat2 = (-in_TEXCOORD0.y) + 1.0;
					    u_xlat0.w = (u_xlatb0) ? u_xlat2 : in_TEXCOORD0.y;
					    u_xlat0.xyz = in_TEXCOORD0.xyx;
					    phase0_Output0_1 = u_xlat0;
					    vs_TEXCOORD2.xy = u_xlat0.zw;
					vs_TEXCOORD0 = phase0_Output0_1.xy;
					vs_TEXCOORD1 = phase0_Output0_1.zw;
					    return;
					}"
				}
				SubProgram "d3d11 " {
					Keywords { "FOG_LINEAR" }
					"vs_4_0
					
					#version 330
					#extension GL_ARB_explicit_attrib_location : require
					#extension GL_ARB_explicit_uniform_location : require
					
					#define HLSLCC_ENABLE_UNIFORM_BUFFERS 1
					#if HLSLCC_ENABLE_UNIFORM_BUFFERS
					#define UNITY_UNIFORM
					#else
					#define UNITY_UNIFORM uniform
					#endif
					#define UNITY_SUPPORTS_UNIFORM_LOCATION 1
					#if UNITY_SUPPORTS_UNIFORM_LOCATION
					#define UNITY_LOCATION(x) layout(location = x)
					#define UNITY_BINDING(x) layout(binding = x, std140)
					#else
					#define UNITY_LOCATION(x)
					#define UNITY_BINDING(x) layout(std140)
					#endif
					layout(std140) uniform VGlobals {
						vec4 unused_0_0[2];
						vec4 _MainTex_TexelSize;
						vec4 unused_0_2[6];
					};
					layout(std140) uniform UnityPerDraw {
						mat4x4 unity_ObjectToWorld;
						vec4 unused_1_1[6];
					};
					layout(std140) uniform UnityPerFrame {
						vec4 unused_2_0[17];
						mat4x4 unity_MatrixVP;
						vec4 unused_2_2[2];
					};
					in  vec4 in_POSITION0;
					in  vec4 in_TEXCOORD0;
					out vec2 vs_TEXCOORD0;
					 vec4 phase0_Output0_1;
					out vec2 vs_TEXCOORD1;
					out vec2 vs_TEXCOORD2;
					vec4 u_xlat0;
					bool u_xlatb0;
					vec4 u_xlat1;
					float u_xlat2;
					void main()
					{
					    u_xlat0 = in_POSITION0.yyyy * unity_ObjectToWorld[1];
					    u_xlat0 = unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    u_xlat0 = u_xlat0 + unity_ObjectToWorld[3];
					    u_xlat1 = u_xlat0.yyyy * unity_MatrixVP[1];
					    u_xlat1 = unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
					    u_xlat1 = unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
					    gl_Position = unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
					    u_xlatb0 = _MainTex_TexelSize.y<0.0;
					    u_xlat2 = (-in_TEXCOORD0.y) + 1.0;
					    u_xlat0.w = (u_xlatb0) ? u_xlat2 : in_TEXCOORD0.y;
					    u_xlat0.xyz = in_TEXCOORD0.xyx;
					    phase0_Output0_1 = u_xlat0;
					    vs_TEXCOORD2.xy = u_xlat0.zw;
					vs_TEXCOORD0 = phase0_Output0_1.xy;
					vs_TEXCOORD1 = phase0_Output0_1.zw;
					    return;
					}"
				}
			}
			Program "fp" {
				SubProgram "d3d11 " {
					Keywords { "FOG_OFF" }
					"ps_4_0
					
					#version 330
					#extension GL_ARB_explicit_attrib_location : require
					#extension GL_ARB_explicit_uniform_location : require
					
					#define HLSLCC_ENABLE_UNIFORM_BUFFERS 1
					#if HLSLCC_ENABLE_UNIFORM_BUFFERS
					#define UNITY_UNIFORM
					#else
					#define UNITY_UNIFORM uniform
					#endif
					#define UNITY_SUPPORTS_UNIFORM_LOCATION 1
					#if UNITY_SUPPORTS_UNIFORM_LOCATION
					#define UNITY_LOCATION(x) layout(location = x)
					#define UNITY_BINDING(x) layout(binding = x, std140)
					#else
					#define UNITY_LOCATION(x)
					#define UNITY_BINDING(x) layout(std140)
					#endif
					layout(std140) uniform PGlobals {
						vec4 unused_0_0[4];
						vec4 _CameraDepthTexture_ST;
						int _SampleCount;
						vec4 unused_0_3;
						float _Intensity;
						float _Radius;
						float _Downsample;
						vec4 unused_0_7;
					};
					layout(std140) uniform UnityPerCamera {
						vec4 unused_1_0[5];
						vec4 _ProjectionParams;
						vec4 _ScreenParams;
						vec4 _ZBufferParams;
						vec4 unity_OrthoParams;
					};
					layout(std140) uniform UnityPerCameraRare {
						vec4 unused_2_0[6];
						mat4x4 unity_CameraProjection;
						vec4 unused_2_2[12];
					};
					uniform  sampler2D _CameraDepthNormalsTexture;
					uniform  sampler2D _CameraDepthTexture;
					in  vec2 vs_TEXCOORD0;
					in  vec2 vs_TEXCOORD1;
					layout(location = 0) out vec4 SV_Target0;
					vec2 u_xlat0;
					int u_xlati0;
					bvec2 u_xlatb0;
					vec4 u_xlat1;
					int u_xlati1;
					bool u_xlatb1;
					vec3 u_xlat2;
					vec4 u_xlat3;
					bvec2 u_xlatb3;
					vec2 u_xlat4;
					vec2 u_xlat5;
					vec4 u_xlat6;
					bvec2 u_xlatb6;
					float u_xlat7;
					vec2 u_xlat8;
					float u_xlat9;
					bool u_xlatb9;
					vec3 u_xlat10;
					vec3 u_xlat14;
					int u_xlati14;
					bvec2 u_xlatb14;
					float u_xlat18;
					vec2 u_xlat22;
					float u_xlat27;
					float u_xlat29;
					bool u_xlatb29;
					float u_xlat30;
					int u_xlati30;
					bool u_xlatb30;
					void main()
					{
					    u_xlat0.xy = vs_TEXCOORD0.xy * _CameraDepthTexture_ST.xy + _CameraDepthTexture_ST.zw;
					    u_xlat1 = texture(_CameraDepthNormalsTexture, u_xlat0.xy);
					    u_xlat1.xyz = u_xlat1.xyz * vec3(3.55539989, 3.55539989, 0.0) + vec3(-1.77769995, -1.77769995, 1.0);
					    u_xlat18 = dot(u_xlat1.xyz, u_xlat1.xyz);
					    u_xlat18 = 2.0 / u_xlat18;
					    u_xlat10.xy = u_xlat1.xy * vec2(u_xlat18);
					    u_xlat10.z = u_xlat18 + -1.0;
					    u_xlat2.xyz = u_xlat10.xyz * vec3(1.0, 1.0, -1.0);
					    u_xlat3 = texture(_CameraDepthTexture, u_xlat0.xy);
					    u_xlat18 = (-unity_OrthoParams.w) + 1.0;
					    u_xlat27 = u_xlat3.x * _ZBufferParams.x;
					    u_xlat1.x = (-unity_OrthoParams.w) * u_xlat27 + 1.0;
					    u_xlat27 = u_xlat18 * u_xlat27 + _ZBufferParams.y;
					    u_xlat27 = u_xlat1.x / u_xlat27;
					    u_xlatb3.xy = lessThan(u_xlat0.xyxx, vec4(0.0, 0.0, 0.0, 0.0)).xy;
					    u_xlatb1 = u_xlatb3.y || u_xlatb3.x;
					    u_xlati1 = u_xlatb1 ? 1 : int(0);
					    u_xlatb0.xy = lessThan(vec4(1.0, 1.0, 0.0, 0.0), u_xlat0.xyxx).xy;
					    u_xlatb0.x = u_xlatb0.y || u_xlatb0.x;
					    u_xlati0 = u_xlatb0.x ? 1 : int(0);
					    u_xlati0 = u_xlati0 + u_xlati1;
					    u_xlat0.x = float(u_xlati0);
					    u_xlatb9 = 9.99999975e-06>=u_xlat27;
					    u_xlat9 = u_xlatb9 ? 1.0 : float(0.0);
					    u_xlat0.x = u_xlat9 + u_xlat0.x;
					    u_xlat0.x = u_xlat0.x * 100000000.0;
					    u_xlat3.z = u_xlat27 * _ProjectionParams.z + u_xlat0.x;
					    u_xlat0.xy = vs_TEXCOORD1.xy * vec2(2.0, 2.0) + vec2(-1.0, -1.0);
					    u_xlat0.xy = u_xlat0.xy + (-unity_CameraProjection[2].xy);
					    u_xlat4.x = unity_CameraProjection[0].x;
					    u_xlat4.y = unity_CameraProjection[1].y;
					    u_xlat0.xy = u_xlat0.xy / u_xlat4.xy;
					    u_xlat27 = (-u_xlat3.z) + 1.0;
					    u_xlat27 = unity_OrthoParams.w * u_xlat27 + u_xlat3.z;
					    u_xlat3.xy = vec2(u_xlat27) * u_xlat0.xy;
					    u_xlat0.xy = vs_TEXCOORD0.xy * vec2(vec2(_Downsample, _Downsample));
					    u_xlat0.xy = u_xlat0.xy * _ScreenParams.xy;
					    u_xlat0.xy = floor(u_xlat0.xy);
					    u_xlat0.x = dot(vec2(0.0671105608, 0.00583714992), u_xlat0.xy);
					    u_xlat0.x = fract(u_xlat0.x);
					    u_xlat0.x = u_xlat0.x * 52.9829178;
					    u_xlat0.x = fract(u_xlat0.x);
					    u_xlat9 = float(_SampleCount);
					    u_xlat5.x = 12.9898005;
					    u_xlat27 = 0.0;
					    for(int u_xlati_loop_1 = 0 ; u_xlati_loop_1<_SampleCount ; u_xlati_loop_1++)
					    {
					        u_xlat29 = float(u_xlati_loop_1);
					        u_xlat29 = u_xlat29 * 1.00010002;
					        u_xlat29 = floor(u_xlat29);
					        u_xlat5.y = vs_TEXCOORD0.x * 1.00000001e-10 + u_xlat29;
					        u_xlat30 = u_xlat5.y * 78.2330017;
					        u_xlat30 = sin(u_xlat30);
					        u_xlat30 = u_xlat30 * 43758.5469;
					        u_xlat30 = fract(u_xlat30);
					        u_xlat30 = u_xlat0.x + u_xlat30;
					        u_xlat30 = fract(u_xlat30);
					        u_xlat6.z = u_xlat30 * 2.0 + -1.0;
					        u_xlat30 = dot(u_xlat5.xy, vec2(1.0, 78.2330017));
					        u_xlat30 = sin(u_xlat30);
					        u_xlat30 = u_xlat30 * 43758.5469;
					        u_xlat30 = fract(u_xlat30);
					        u_xlat30 = u_xlat0.x + u_xlat30;
					        u_xlat30 = u_xlat30 * 6.28318548;
					        u_xlat7 = sin(u_xlat30);
					        u_xlat8.x = cos(u_xlat30);
					        u_xlat30 = (-u_xlat6.z) * u_xlat6.z + 1.0;
					        u_xlat30 = sqrt(u_xlat30);
					        u_xlat8.y = u_xlat7;
					        u_xlat6.xy = vec2(u_xlat30) * u_xlat8.xy;
					        u_xlat29 = u_xlat29 + 1.0;
					        u_xlat29 = u_xlat29 / u_xlat9;
					        u_xlat29 = sqrt(u_xlat29);
					        u_xlat29 = u_xlat29 * _Radius;
					        u_xlat14.xyz = vec3(u_xlat29) * u_xlat6.xyz;
					        u_xlat29 = dot((-u_xlat2.xyz), u_xlat14.xyz);
					        u_xlatb29 = u_xlat29>=0.0;
					        u_xlat14.xyz = (bool(u_xlatb29)) ? (-u_xlat14.xyz) : u_xlat14.xyz;
					        u_xlat14.xyz = u_xlat3.xyz + u_xlat14.xyz;
					        u_xlat22.xy = u_xlat14.yy * unity_CameraProjection[1].xy;
					        u_xlat22.xy = unity_CameraProjection[0].xy * u_xlat14.xx + u_xlat22.xy;
					        u_xlat22.xy = unity_CameraProjection[2].xy * u_xlat14.zz + u_xlat22.xy;
					        u_xlat29 = (-u_xlat14.z) + 1.0;
					        u_xlat29 = unity_OrthoParams.w * u_xlat29 + u_xlat14.z;
					        u_xlat22.xy = u_xlat22.xy / vec2(u_xlat29);
					        u_xlat22.xy = u_xlat22.xy + vec2(1.0, 1.0);
					        u_xlat14.xy = u_xlat22.xy * vec2(0.5, 0.5);
					        u_xlat14.xy = u_xlat14.xy * _CameraDepthTexture_ST.xy + _CameraDepthTexture_ST.zw;
					        u_xlat6 = texture(_CameraDepthTexture, u_xlat14.xy);
					        u_xlat29 = u_xlat6.x * _ZBufferParams.x;
					        u_xlat30 = (-unity_OrthoParams.w) * u_xlat29 + 1.0;
					        u_xlat29 = u_xlat18 * u_xlat29 + _ZBufferParams.y;
					        u_xlat29 = u_xlat30 / u_xlat29;
					        u_xlatb6.xy = lessThan(u_xlat14.xyxx, vec4(0.0, 0.0, 0.0, 0.0)).xy;
					        u_xlatb30 = u_xlatb6.y || u_xlatb6.x;
					        u_xlati30 = u_xlatb30 ? 1 : int(0);
					        u_xlatb14.xy = lessThan(vec4(1.0, 1.0, 0.0, 0.0), u_xlat14.xyxx).xy;
					        u_xlatb14.x = u_xlatb14.y || u_xlatb14.x;
					        u_xlati14 = u_xlatb14.x ? 1 : int(0);
					        u_xlati30 = u_xlati30 + u_xlati14;
					        u_xlat30 = float(u_xlati30);
					        u_xlatb14.x = 9.99999975e-06>=u_xlat29;
					        u_xlat14.x = u_xlatb14.x ? 1.0 : float(0.0);
					        u_xlat30 = u_xlat30 + u_xlat14.x;
					        u_xlat30 = u_xlat30 * 100000000.0;
					        u_xlat6.z = u_xlat29 * _ProjectionParams.z + u_xlat30;
					        u_xlat22.xy = u_xlat22.xy + (-unity_CameraProjection[2].xy);
					        u_xlat22.xy = u_xlat22.xy + vec2(-1.0, -1.0);
					        u_xlat22.xy = u_xlat22.xy / u_xlat4.xy;
					        u_xlat29 = (-u_xlat6.z) + 1.0;
					        u_xlat29 = unity_OrthoParams.w * u_xlat29 + u_xlat6.z;
					        u_xlat6.xy = vec2(u_xlat29) * u_xlat22.xy;
					        u_xlat14.xyz = (-u_xlat3.xyz) + u_xlat6.xyz;
					        u_xlat29 = dot(u_xlat14.xyz, u_xlat2.xyz);
					        u_xlat29 = (-u_xlat3.z) * 0.00200000009 + u_xlat29;
					        u_xlat29 = max(u_xlat29, 0.0);
					        u_xlat30 = dot(u_xlat14.xyz, u_xlat14.xyz);
					        u_xlat30 = u_xlat30 + 9.99999975e-05;
					        u_xlat29 = u_xlat29 / u_xlat30;
					        u_xlat27 = u_xlat27 + u_xlat29;
					    }
					    u_xlat0.x = u_xlat27 * _Radius;
					    u_xlat0.x = u_xlat0.x * _Intensity;
					    u_xlat0.x = u_xlat0.x / u_xlat9;
					    u_xlat0.x = log2(u_xlat0.x);
					    u_xlat0.x = u_xlat0.x * 0.600000024;
					    SV_Target0.x = exp2(u_xlat0.x);
					    SV_Target0.yzw = u_xlat10.xyz * vec3(0.5, 0.5, -0.5) + vec3(0.5, 0.5, 0.5);
					    return;
					}"
				}
				SubProgram "d3d11 " {
					Keywords { "FOG_LINEAR" }
					"ps_4_0
					
					#version 330
					#extension GL_ARB_explicit_attrib_location : require
					#extension GL_ARB_explicit_uniform_location : require
					
					#define HLSLCC_ENABLE_UNIFORM_BUFFERS 1
					#if HLSLCC_ENABLE_UNIFORM_BUFFERS
					#define UNITY_UNIFORM
					#else
					#define UNITY_UNIFORM uniform
					#endif
					#define UNITY_SUPPORTS_UNIFORM_LOCATION 1
					#if UNITY_SUPPORTS_UNIFORM_LOCATION
					#define UNITY_LOCATION(x) layout(location = x)
					#define UNITY_BINDING(x) layout(binding = x, std140)
					#else
					#define UNITY_LOCATION(x)
					#define UNITY_BINDING(x) layout(std140)
					#endif
					layout(std140) uniform PGlobals {
						vec4 unused_0_0[4];
						vec4 _CameraDepthTexture_ST;
						int _SampleCount;
						vec4 unused_0_3;
						float _Intensity;
						float _Radius;
						float _Downsample;
						vec3 _FogParams;
					};
					layout(std140) uniform UnityPerCamera {
						vec4 unused_1_0[5];
						vec4 _ProjectionParams;
						vec4 _ScreenParams;
						vec4 _ZBufferParams;
						vec4 unity_OrthoParams;
					};
					layout(std140) uniform UnityPerCameraRare {
						vec4 unused_2_0[6];
						mat4x4 unity_CameraProjection;
						vec4 unused_2_2[12];
					};
					uniform  sampler2D _CameraDepthNormalsTexture;
					uniform  sampler2D _CameraDepthTexture;
					in  vec2 vs_TEXCOORD0;
					in  vec2 vs_TEXCOORD1;
					layout(location = 0) out vec4 SV_Target0;
					vec2 u_xlat0;
					int u_xlati0;
					bvec2 u_xlatb0;
					vec4 u_xlat1;
					int u_xlati1;
					bool u_xlatb1;
					vec4 u_xlat2;
					vec4 u_xlat3;
					bvec2 u_xlatb3;
					vec2 u_xlat4;
					vec2 u_xlat5;
					vec4 u_xlat6;
					bvec2 u_xlatb6;
					float u_xlat7;
					vec2 u_xlat8;
					float u_xlat9;
					bool u_xlatb9;
					vec3 u_xlat10;
					vec3 u_xlat14;
					int u_xlati14;
					bvec2 u_xlatb14;
					float u_xlat18;
					vec2 u_xlat22;
					float u_xlat27;
					float u_xlat29;
					bool u_xlatb29;
					float u_xlat30;
					int u_xlati30;
					bool u_xlatb30;
					void main()
					{
					    u_xlat0.xy = vs_TEXCOORD0.xy * _CameraDepthTexture_ST.xy + _CameraDepthTexture_ST.zw;
					    u_xlat1 = texture(_CameraDepthNormalsTexture, u_xlat0.xy);
					    u_xlat1.xyz = u_xlat1.xyz * vec3(3.55539989, 3.55539989, 0.0) + vec3(-1.77769995, -1.77769995, 1.0);
					    u_xlat18 = dot(u_xlat1.xyz, u_xlat1.xyz);
					    u_xlat18 = 2.0 / u_xlat18;
					    u_xlat10.xy = u_xlat1.xy * vec2(u_xlat18);
					    u_xlat10.z = u_xlat18 + -1.0;
					    u_xlat2.xyz = u_xlat10.xyz * vec3(1.0, 1.0, -1.0);
					    u_xlat3 = texture(_CameraDepthTexture, u_xlat0.xy);
					    u_xlat18 = (-unity_OrthoParams.w) + 1.0;
					    u_xlat27 = u_xlat3.x * _ZBufferParams.x;
					    u_xlat1.x = (-unity_OrthoParams.w) * u_xlat27 + 1.0;
					    u_xlat27 = u_xlat18 * u_xlat27 + _ZBufferParams.y;
					    u_xlat27 = u_xlat1.x / u_xlat27;
					    u_xlatb3.xy = lessThan(u_xlat0.xyxx, vec4(0.0, 0.0, 0.0, 0.0)).xy;
					    u_xlatb1 = u_xlatb3.y || u_xlatb3.x;
					    u_xlati1 = u_xlatb1 ? 1 : int(0);
					    u_xlatb0.xy = lessThan(vec4(1.0, 1.0, 0.0, 0.0), u_xlat0.xyxx).xy;
					    u_xlatb0.x = u_xlatb0.y || u_xlatb0.x;
					    u_xlati0 = u_xlatb0.x ? 1 : int(0);
					    u_xlati0 = u_xlati0 + u_xlati1;
					    u_xlat0.x = float(u_xlati0);
					    u_xlatb9 = 9.99999975e-06>=u_xlat27;
					    u_xlat9 = u_xlatb9 ? 1.0 : float(0.0);
					    u_xlat0.x = u_xlat9 + u_xlat0.x;
					    u_xlat0.x = u_xlat0.x * 100000000.0;
					    u_xlat3.z = u_xlat27 * _ProjectionParams.z + u_xlat0.x;
					    u_xlat0.xy = vs_TEXCOORD1.xy * vec2(2.0, 2.0) + vec2(-1.0, -1.0);
					    u_xlat0.xy = u_xlat0.xy + (-unity_CameraProjection[2].xy);
					    u_xlat4.x = unity_CameraProjection[0].x;
					    u_xlat4.y = unity_CameraProjection[1].y;
					    u_xlat0.xy = u_xlat0.xy / u_xlat4.xy;
					    u_xlat27 = (-u_xlat3.z) + 1.0;
					    u_xlat27 = unity_OrthoParams.w * u_xlat27 + u_xlat3.z;
					    u_xlat3.xy = vec2(u_xlat27) * u_xlat0.xy;
					    u_xlat0.xy = vs_TEXCOORD0.xy * vec2(vec2(_Downsample, _Downsample));
					    u_xlat0.xy = u_xlat0.xy * _ScreenParams.xy;
					    u_xlat0.xy = floor(u_xlat0.xy);
					    u_xlat0.x = dot(vec2(0.0671105608, 0.00583714992), u_xlat0.xy);
					    u_xlat0.x = fract(u_xlat0.x);
					    u_xlat0.x = u_xlat0.x * 52.9829178;
					    u_xlat0.x = fract(u_xlat0.x);
					    u_xlat9 = float(_SampleCount);
					    u_xlat5.x = 12.9898005;
					    u_xlat27 = 0.0;
					    for(int u_xlati_loop_1 = 0 ; u_xlati_loop_1<_SampleCount ; u_xlati_loop_1++)
					    {
					        u_xlat29 = float(u_xlati_loop_1);
					        u_xlat29 = u_xlat29 * 1.00010002;
					        u_xlat29 = floor(u_xlat29);
					        u_xlat5.y = vs_TEXCOORD0.x * 1.00000001e-10 + u_xlat29;
					        u_xlat30 = u_xlat5.y * 78.2330017;
					        u_xlat30 = sin(u_xlat30);
					        u_xlat30 = u_xlat30 * 43758.5469;
					        u_xlat30 = fract(u_xlat30);
					        u_xlat30 = u_xlat0.x + u_xlat30;
					        u_xlat30 = fract(u_xlat30);
					        u_xlat6.z = u_xlat30 * 2.0 + -1.0;
					        u_xlat30 = dot(u_xlat5.xy, vec2(1.0, 78.2330017));
					        u_xlat30 = sin(u_xlat30);
					        u_xlat30 = u_xlat30 * 43758.5469;
					        u_xlat30 = fract(u_xlat30);
					        u_xlat30 = u_xlat0.x + u_xlat30;
					        u_xlat30 = u_xlat30 * 6.28318548;
					        u_xlat7 = sin(u_xlat30);
					        u_xlat8.x = cos(u_xlat30);
					        u_xlat30 = (-u_xlat6.z) * u_xlat6.z + 1.0;
					        u_xlat30 = sqrt(u_xlat30);
					        u_xlat8.y = u_xlat7;
					        u_xlat6.xy = vec2(u_xlat30) * u_xlat8.xy;
					        u_xlat29 = u_xlat29 + 1.0;
					        u_xlat29 = u_xlat29 / u_xlat9;
					        u_xlat29 = sqrt(u_xlat29);
					        u_xlat29 = u_xlat29 * _Radius;
					        u_xlat14.xyz = vec3(u_xlat29) * u_xlat6.xyz;
					        u_xlat29 = dot((-u_xlat2.xyz), u_xlat14.xyz);
					        u_xlatb29 = u_xlat29>=0.0;
					        u_xlat14.xyz = (bool(u_xlatb29)) ? (-u_xlat14.xyz) : u_xlat14.xyz;
					        u_xlat14.xyz = u_xlat3.xyz + u_xlat14.xyz;
					        u_xlat22.xy = u_xlat14.yy * unity_CameraProjection[1].xy;
					        u_xlat22.xy = unity_CameraProjection[0].xy * u_xlat14.xx + u_xlat22.xy;
					        u_xlat22.xy = unity_CameraProjection[2].xy * u_xlat14.zz + u_xlat22.xy;
					        u_xlat29 = (-u_xlat14.z) + 1.0;
					        u_xlat29 = unity_OrthoParams.w * u_xlat29 + u_xlat14.z;
					        u_xlat22.xy = u_xlat22.xy / vec2(u_xlat29);
					        u_xlat22.xy = u_xlat22.xy + vec2(1.0, 1.0);
					        u_xlat14.xy = u_xlat22.xy * vec2(0.5, 0.5);
					        u_xlat14.xy = u_xlat14.xy * _CameraDepthTexture_ST.xy + _CameraDepthTexture_ST.zw;
					        u_xlat6 = texture(_CameraDepthTexture, u_xlat14.xy);
					        u_xlat29 = u_xlat6.x * _ZBufferParams.x;
					        u_xlat30 = (-unity_OrthoParams.w) * u_xlat29 + 1.0;
					        u_xlat29 = u_xlat18 * u_xlat29 + _ZBufferParams.y;
					        u_xlat29 = u_xlat30 / u_xlat29;
					        u_xlatb6.xy = lessThan(u_xlat14.xyxx, vec4(0.0, 0.0, 0.0, 0.0)).xy;
					        u_xlatb30 = u_xlatb6.y || u_xlatb6.x;
					        u_xlati30 = u_xlatb30 ? 1 : int(0);
					        u_xlatb14.xy = lessThan(vec4(1.0, 1.0, 0.0, 0.0), u_xlat14.xyxx).xy;
					        u_xlatb14.x = u_xlatb14.y || u_xlatb14.x;
					        u_xlati14 = u_xlatb14.x ? 1 : int(0);
					        u_xlati30 = u_xlati30 + u_xlati14;
					        u_xlat30 = float(u_xlati30);
					        u_xlatb14.x = 9.99999975e-06>=u_xlat29;
					        u_xlat14.x = u_xlatb14.x ? 1.0 : float(0.0);
					        u_xlat30 = u_xlat30 + u_xlat14.x;
					        u_xlat30 = u_xlat30 * 100000000.0;
					        u_xlat6.z = u_xlat29 * _ProjectionParams.z + u_xlat30;
					        u_xlat22.xy = u_xlat22.xy + (-unity_CameraProjection[2].xy);
					        u_xlat22.xy = u_xlat22.xy + vec2(-1.0, -1.0);
					        u_xlat22.xy = u_xlat22.xy / u_xlat4.xy;
					        u_xlat29 = (-u_xlat6.z) + 1.0;
					        u_xlat29 = unity_OrthoParams.w * u_xlat29 + u_xlat6.z;
					        u_xlat6.xy = vec2(u_xlat29) * u_xlat22.xy;
					        u_xlat14.xyz = (-u_xlat3.xyz) + u_xlat6.xyz;
					        u_xlat29 = dot(u_xlat14.xyz, u_xlat2.xyz);
					        u_xlat29 = (-u_xlat3.z) * 0.00200000009 + u_xlat29;
					        u_xlat29 = max(u_xlat29, 0.0);
					        u_xlat30 = dot(u_xlat14.xyz, u_xlat14.xyz);
					        u_xlat30 = u_xlat30 + 9.99999975e-05;
					        u_xlat29 = u_xlat29 / u_xlat30;
					        u_xlat27 = u_xlat27 + u_xlat29;
					    }
					    u_xlat0.x = u_xlat27 * _Radius;
					    u_xlat0.x = u_xlat0.x * _Intensity;
					    u_xlat0.x = u_xlat0.x / u_xlat9;
					    u_xlat0.x = log2(u_xlat0.x);
					    u_xlat0.x = u_xlat0.x * 0.600000024;
					    u_xlat0.x = exp2(u_xlat0.x);
					    u_xlat2 = texture(_CameraDepthTexture, vs_TEXCOORD0.xy);
					    u_xlat9 = _ZBufferParams.x * u_xlat2.x + _ZBufferParams.y;
					    u_xlat9 = float(1.0) / u_xlat9;
					    u_xlat9 = u_xlat9 * _ProjectionParams.z + (-_ProjectionParams.y);
					    u_xlat9 = (-u_xlat9) + _FogParams.z;
					    u_xlat18 = (-_FogParams.y) + _FogParams.z;
					    u_xlat9 = u_xlat9 / u_xlat18;
					    u_xlat9 = clamp(u_xlat9, 0.0, 1.0);
					    SV_Target0.x = u_xlat9 * u_xlat0.x;
					    SV_Target0.yzw = u_xlat10.xyz * vec3(0.5, 0.5, -0.5) + vec3(0.5, 0.5, 0.5);
					    return;
					}"
				}
			}
		}
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 124839
			Program "vp" {
				SubProgram "d3d11 " {
					Keywords { "FOG_OFF" }
					"vs_4_0
					
					#version 330
					#extension GL_ARB_explicit_attrib_location : require
					#extension GL_ARB_explicit_uniform_location : require
					
					#define HLSLCC_ENABLE_UNIFORM_BUFFERS 1
					#if HLSLCC_ENABLE_UNIFORM_BUFFERS
					#define UNITY_UNIFORM
					#else
					#define UNITY_UNIFORM uniform
					#endif
					#define UNITY_SUPPORTS_UNIFORM_LOCATION 1
					#if UNITY_SUPPORTS_UNIFORM_LOCATION
					#define UNITY_LOCATION(x) layout(location = x)
					#define UNITY_BINDING(x) layout(binding = x, std140)
					#else
					#define UNITY_LOCATION(x)
					#define UNITY_BINDING(x) layout(std140)
					#endif
					layout(std140) uniform VGlobals {
						vec4 unused_0_0[2];
						vec4 _MainTex_TexelSize;
						vec4 unused_0_2[6];
					};
					layout(std140) uniform UnityPerDraw {
						mat4x4 unity_ObjectToWorld;
						vec4 unused_1_1[6];
					};
					layout(std140) uniform UnityPerFrame {
						vec4 unused_2_0[17];
						mat4x4 unity_MatrixVP;
						vec4 unused_2_2[2];
					};
					in  vec4 in_POSITION0;
					in  vec4 in_TEXCOORD0;
					out vec2 vs_TEXCOORD0;
					 vec4 phase0_Output0_1;
					out vec2 vs_TEXCOORD1;
					out vec2 vs_TEXCOORD2;
					vec4 u_xlat0;
					bool u_xlatb0;
					vec4 u_xlat1;
					float u_xlat2;
					void main()
					{
					    u_xlat0 = in_POSITION0.yyyy * unity_ObjectToWorld[1];
					    u_xlat0 = unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    u_xlat0 = u_xlat0 + unity_ObjectToWorld[3];
					    u_xlat1 = u_xlat0.yyyy * unity_MatrixVP[1];
					    u_xlat1 = unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
					    u_xlat1 = unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
					    gl_Position = unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
					    u_xlatb0 = _MainTex_TexelSize.y<0.0;
					    u_xlat2 = (-in_TEXCOORD0.y) + 1.0;
					    u_xlat0.w = (u_xlatb0) ? u_xlat2 : in_TEXCOORD0.y;
					    u_xlat0.xyz = in_TEXCOORD0.xyx;
					    phase0_Output0_1 = u_xlat0;
					    vs_TEXCOORD2.xy = u_xlat0.zw;
					vs_TEXCOORD0 = phase0_Output0_1.xy;
					vs_TEXCOORD1 = phase0_Output0_1.zw;
					    return;
					}"
				}
				SubProgram "d3d11 " {
					Keywords { "FOG_LINEAR" }
					"vs_4_0
					
					#version 330
					#extension GL_ARB_explicit_attrib_location : require
					#extension GL_ARB_explicit_uniform_location : require
					
					#define HLSLCC_ENABLE_UNIFORM_BUFFERS 1
					#if HLSLCC_ENABLE_UNIFORM_BUFFERS
					#define UNITY_UNIFORM
					#else
					#define UNITY_UNIFORM uniform
					#endif
					#define UNITY_SUPPORTS_UNIFORM_LOCATION 1
					#if UNITY_SUPPORTS_UNIFORM_LOCATION
					#define UNITY_LOCATION(x) layout(location = x)
					#define UNITY_BINDING(x) layout(binding = x, std140)
					#else
					#define UNITY_LOCATION(x)
					#define UNITY_BINDING(x) layout(std140)
					#endif
					layout(std140) uniform VGlobals {
						vec4 unused_0_0[2];
						vec4 _MainTex_TexelSize;
						vec4 unused_0_2[6];
					};
					layout(std140) uniform UnityPerDraw {
						mat4x4 unity_ObjectToWorld;
						vec4 unused_1_1[6];
					};
					layout(std140) uniform UnityPerFrame {
						vec4 unused_2_0[17];
						mat4x4 unity_MatrixVP;
						vec4 unused_2_2[2];
					};
					in  vec4 in_POSITION0;
					in  vec4 in_TEXCOORD0;
					out vec2 vs_TEXCOORD0;
					 vec4 phase0_Output0_1;
					out vec2 vs_TEXCOORD1;
					out vec2 vs_TEXCOORD2;
					vec4 u_xlat0;
					bool u_xlatb0;
					vec4 u_xlat1;
					float u_xlat2;
					void main()
					{
					    u_xlat0 = in_POSITION0.yyyy * unity_ObjectToWorld[1];
					    u_xlat0 = unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    u_xlat0 = u_xlat0 + unity_ObjectToWorld[3];
					    u_xlat1 = u_xlat0.yyyy * unity_MatrixVP[1];
					    u_xlat1 = unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
					    u_xlat1 = unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
					    gl_Position = unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
					    u_xlatb0 = _MainTex_TexelSize.y<0.0;
					    u_xlat2 = (-in_TEXCOORD0.y) + 1.0;
					    u_xlat0.w = (u_xlatb0) ? u_xlat2 : in_TEXCOORD0.y;
					    u_xlat0.xyz = in_TEXCOORD0.xyx;
					    phase0_Output0_1 = u_xlat0;
					    vs_TEXCOORD2.xy = u_xlat0.zw;
					vs_TEXCOORD0 = phase0_Output0_1.xy;
					vs_TEXCOORD1 = phase0_Output0_1.zw;
					    return;
					}"
				}
			}
			Program "fp" {
				SubProgram "d3d11 " {
					Keywords { "FOG_OFF" }
					"ps_4_0
					
					#version 330
					#extension GL_ARB_explicit_attrib_location : require
					#extension GL_ARB_explicit_uniform_location : require
					
					#define HLSLCC_ENABLE_UNIFORM_BUFFERS 1
					#if HLSLCC_ENABLE_UNIFORM_BUFFERS
					#define UNITY_UNIFORM
					#else
					#define UNITY_UNIFORM uniform
					#endif
					#define UNITY_SUPPORTS_UNIFORM_LOCATION 1
					#if UNITY_SUPPORTS_UNIFORM_LOCATION
					#define UNITY_LOCATION(x) layout(location = x)
					#define UNITY_BINDING(x) layout(binding = x, std140)
					#else
					#define UNITY_LOCATION(x)
					#define UNITY_BINDING(x) layout(std140)
					#endif
					layout(std140) uniform PGlobals {
						vec4 unused_0_0[4];
						vec4 _CameraDepthTexture_ST;
						int _SampleCount;
						vec4 unused_0_3;
						float _Intensity;
						float _Radius;
						float _Downsample;
						vec4 unused_0_7;
					};
					layout(std140) uniform UnityPerCamera {
						vec4 unused_1_0[5];
						vec4 _ProjectionParams;
						vec4 _ScreenParams;
						vec4 unused_1_3;
						vec4 unity_OrthoParams;
					};
					layout(std140) uniform UnityPerCameraRare {
						vec4 unused_2_0[6];
						mat4x4 unity_CameraProjection;
						vec4 unused_2_2[12];
					};
					uniform  sampler2D _CameraDepthNormalsTexture;
					in  vec2 vs_TEXCOORD0;
					in  vec2 vs_TEXCOORD1;
					layout(location = 0) out vec4 SV_Target0;
					vec3 u_xlat0;
					ivec4 u_xlati0;
					bvec2 u_xlatb0;
					vec4 u_xlat1;
					bvec2 u_xlatb1;
					vec3 u_xlat2;
					int u_xlati2;
					bool u_xlatb2;
					vec3 u_xlat3;
					vec2 u_xlat4;
					vec2 u_xlat5;
					vec4 u_xlat6;
					bvec2 u_xlatb6;
					vec2 u_xlat7;
					float u_xlat8;
					bool u_xlatb8;
					float u_xlat9;
					vec3 u_xlat10;
					vec3 u_xlat13;
					bvec2 u_xlatb13;
					float u_xlat16;
					int u_xlati17;
					vec2 u_xlat20;
					float u_xlat24;
					float u_xlat25;
					bool u_xlatb25;
					float u_xlat27;
					int u_xlati27;
					bool u_xlatb27;
					void main()
					{
					    u_xlat0.xy = vs_TEXCOORD0.xy * _CameraDepthTexture_ST.xy + _CameraDepthTexture_ST.zw;
					    u_xlat1 = texture(_CameraDepthNormalsTexture, u_xlat0.xy);
					    u_xlat2.xyz = u_xlat1.xyz * vec3(3.55539989, 3.55539989, 0.0) + vec3(-1.77769995, -1.77769995, 1.0);
					    u_xlat16 = dot(u_xlat2.xyz, u_xlat2.xyz);
					    u_xlat16 = 2.0 / u_xlat16;
					    u_xlat10.xy = u_xlat2.xy * vec2(u_xlat16);
					    u_xlat10.z = u_xlat16 + -1.0;
					    u_xlat3.xyz = u_xlat10.xyz * vec3(1.0, 1.0, -1.0);
					    u_xlat16 = dot(u_xlat1.zw, vec2(1.0, 0.00392156886));
					    u_xlatb1.xy = lessThan(u_xlat0.xyxx, vec4(0.0, 0.0, 0.0, 0.0)).xy;
					    u_xlati0.w = int((uint(u_xlatb1.y) * 0xffffffffu) | (uint(u_xlatb1.x) * 0xffffffffu));
					    u_xlatb0.xy = lessThan(vec4(1.0, 1.0, 0.0, 0.0), u_xlat0.xyxx).xy;
					    u_xlati0.x = int((uint(u_xlatb0.y) * 0xffffffffu) | (uint(u_xlatb0.x) * 0xffffffffu));
					    u_xlati0.xw = ivec2(uvec2(u_xlati0.xw) & uvec2(1u, 1u));
					    u_xlati0.x = u_xlati0.x + u_xlati0.w;
					    u_xlat0.x = float(u_xlati0.x);
					    u_xlatb8 = 9.99999975e-06>=u_xlat16;
					    u_xlat8 = u_xlatb8 ? 1.0 : float(0.0);
					    u_xlat0.x = u_xlat8 + u_xlat0.x;
					    u_xlat0.x = u_xlat0.x * 100000000.0;
					    u_xlat0.x = u_xlat16 * _ProjectionParams.z + u_xlat0.x;
					    u_xlat0.z = (-_ProjectionParams.z) * 1.52587891e-05 + u_xlat0.x;
					    u_xlat1.xy = vs_TEXCOORD1.xy * vec2(2.0, 2.0) + vec2(-1.0, -1.0);
					    u_xlat1.xy = u_xlat1.xy + (-unity_CameraProjection[2].xy);
					    u_xlat4.x = unity_CameraProjection[0].x;
					    u_xlat4.y = unity_CameraProjection[1].y;
					    u_xlat1.xy = u_xlat1.xy / u_xlat4.xy;
					    u_xlat24 = (-u_xlat0.z) + 1.0;
					    u_xlat24 = unity_OrthoParams.w * u_xlat24 + u_xlat0.z;
					    u_xlat0.xy = vec2(u_xlat24) * u_xlat1.xy;
					    u_xlat1.xy = vs_TEXCOORD0.xy * vec2(vec2(_Downsample, _Downsample));
					    u_xlat1.xy = u_xlat1.xy * _ScreenParams.xy;
					    u_xlat1.xy = floor(u_xlat1.xy);
					    u_xlat24 = dot(vec2(0.0671105608, 0.00583714992), u_xlat1.xy);
					    u_xlat24 = fract(u_xlat24);
					    u_xlat24 = u_xlat24 * 52.9829178;
					    u_xlat24 = fract(u_xlat24);
					    u_xlat1.x = float(_SampleCount);
					    u_xlat5.x = 12.9898005;
					    u_xlat9 = float(0.0);
					    for(int u_xlati_loop_1 = int(0) ; u_xlati_loop_1<_SampleCount ; u_xlati_loop_1++)
					    {
					        u_xlat25 = float(u_xlati_loop_1);
					        u_xlat25 = u_xlat25 * 1.00010002;
					        u_xlat25 = floor(u_xlat25);
					        u_xlat5.y = vs_TEXCOORD0.x * 1.00000001e-10 + u_xlat25;
					        u_xlat2.x = u_xlat5.y * 78.2330017;
					        u_xlat2.x = sin(u_xlat2.x);
					        u_xlat2.x = u_xlat2.x * 43758.5469;
					        u_xlat2.x = fract(u_xlat2.x);
					        u_xlat2.x = u_xlat24 + u_xlat2.x;
					        u_xlat2.x = fract(u_xlat2.x);
					        u_xlat6.z = u_xlat2.x * 2.0 + -1.0;
					        u_xlat2.x = dot(u_xlat5.xy, vec2(1.0, 78.2330017));
					        u_xlat2.x = sin(u_xlat2.x);
					        u_xlat2.x = u_xlat2.x * 43758.5469;
					        u_xlat2.x = fract(u_xlat2.x);
					        u_xlat2.x = u_xlat24 + u_xlat2.x;
					        u_xlat2.x = u_xlat2.x * 6.28318548;
					        u_xlat7.x = cos(u_xlat2.x);
					        u_xlat2.x = sin(u_xlat2.x);
					        u_xlat27 = (-u_xlat6.z) * u_xlat6.z + 1.0;
					        u_xlat27 = sqrt(u_xlat27);
					        u_xlat7.y = u_xlat2.x;
					        u_xlat6.xy = vec2(u_xlat27) * u_xlat7.xy;
					        u_xlat25 = u_xlat25 + 1.0;
					        u_xlat25 = u_xlat25 / u_xlat1.x;
					        u_xlat25 = sqrt(u_xlat25);
					        u_xlat25 = u_xlat25 * _Radius;
					        u_xlat13.xyz = vec3(u_xlat25) * u_xlat6.xyz;
					        u_xlat25 = dot((-u_xlat3.xyz), u_xlat13.xyz);
					        u_xlatb25 = u_xlat25>=0.0;
					        u_xlat13.xyz = (bool(u_xlatb25)) ? (-u_xlat13.xyz) : u_xlat13.xyz;
					        u_xlat13.xyz = u_xlat0.xyz + u_xlat13.xyz;
					        u_xlat20.xy = u_xlat13.yy * unity_CameraProjection[1].xy;
					        u_xlat20.xy = unity_CameraProjection[0].xy * u_xlat13.xx + u_xlat20.xy;
					        u_xlat20.xy = unity_CameraProjection[2].xy * u_xlat13.zz + u_xlat20.xy;
					        u_xlat25 = (-u_xlat13.z) + 1.0;
					        u_xlat25 = unity_OrthoParams.w * u_xlat25 + u_xlat13.z;
					        u_xlat20.xy = u_xlat20.xy / vec2(u_xlat25);
					        u_xlat20.xy = u_xlat20.xy + vec2(1.0, 1.0);
					        u_xlat13.xy = u_xlat20.xy * vec2(0.5, 0.5);
					        u_xlat13.xy = u_xlat13.xy * _CameraDepthTexture_ST.xy + _CameraDepthTexture_ST.zw;
					        u_xlat6 = texture(_CameraDepthNormalsTexture, u_xlat13.xy);
					        u_xlat25 = dot(u_xlat6.zw, vec2(1.0, 0.00392156886));
					        u_xlatb6.xy = lessThan(u_xlat13.xyxx, vec4(0.0, 0.0, 0.0, 0.0)).xy;
					        u_xlatb2 = u_xlatb6.y || u_xlatb6.x;
					        u_xlati2 = u_xlatb2 ? 1 : int(0);
					        u_xlatb13.xy = lessThan(vec4(1.0, 1.0, 0.0, 0.0), u_xlat13.xyxx).xy;
					        u_xlatb27 = u_xlatb13.y || u_xlatb13.x;
					        u_xlati27 = u_xlatb27 ? 1 : int(0);
					        u_xlati2 = u_xlati2 + u_xlati27;
					        u_xlat2.x = float(u_xlati2);
					        u_xlatb27 = 9.99999975e-06>=u_xlat25;
					        u_xlat27 = u_xlatb27 ? 1.0 : float(0.0);
					        u_xlat2.x = u_xlat2.x + u_xlat27;
					        u_xlat2.x = u_xlat2.x * 100000000.0;
					        u_xlat6.z = u_xlat25 * _ProjectionParams.z + u_xlat2.x;
					        u_xlat20.xy = u_xlat20.xy + (-unity_CameraProjection[2].xy);
					        u_xlat20.xy = u_xlat20.xy + vec2(-1.0, -1.0);
					        u_xlat20.xy = u_xlat20.xy / u_xlat4.xy;
					        u_xlat25 = (-u_xlat6.z) + 1.0;
					        u_xlat25 = unity_OrthoParams.w * u_xlat25 + u_xlat6.z;
					        u_xlat6.xy = vec2(u_xlat25) * u_xlat20.xy;
					        u_xlat13.xyz = (-u_xlat0.xyz) + u_xlat6.xyz;
					        u_xlat25 = dot(u_xlat13.xyz, u_xlat3.xyz);
					        u_xlat25 = (-u_xlat0.z) * 0.00200000009 + u_xlat25;
					        u_xlat25 = max(u_xlat25, 0.0);
					        u_xlat2.x = dot(u_xlat13.xyz, u_xlat13.xyz);
					        u_xlat2.x = u_xlat2.x + 9.99999975e-05;
					        u_xlat25 = u_xlat25 / u_xlat2.x;
					        u_xlat9 = u_xlat25 + u_xlat9;
					    }
					    u_xlat0.x = u_xlat9 * _Radius;
					    u_xlat0.x = u_xlat0.x * _Intensity;
					    u_xlat0.x = u_xlat0.x / u_xlat1.x;
					    u_xlat0.x = log2(u_xlat0.x);
					    u_xlat0.x = u_xlat0.x * 0.600000024;
					    SV_Target0.x = exp2(u_xlat0.x);
					    SV_Target0.yzw = u_xlat10.xyz * vec3(0.5, 0.5, -0.5) + vec3(0.5, 0.5, 0.5);
					    return;
					}"
				}
				SubProgram "d3d11 " {
					Keywords { "FOG_LINEAR" }
					"ps_4_0
					
					#version 330
					#extension GL_ARB_explicit_attrib_location : require
					#extension GL_ARB_explicit_uniform_location : require
					
					#define HLSLCC_ENABLE_UNIFORM_BUFFERS 1
					#if HLSLCC_ENABLE_UNIFORM_BUFFERS
					#define UNITY_UNIFORM
					#else
					#define UNITY_UNIFORM uniform
					#endif
					#define UNITY_SUPPORTS_UNIFORM_LOCATION 1
					#if UNITY_SUPPORTS_UNIFORM_LOCATION
					#define UNITY_LOCATION(x) layout(location = x)
					#define UNITY_BINDING(x) layout(binding = x, std140)
					#else
					#define UNITY_LOCATION(x)
					#define UNITY_BINDING(x) layout(std140)
					#endif
					layout(std140) uniform PGlobals {
						vec4 unused_0_0[4];
						vec4 _CameraDepthTexture_ST;
						int _SampleCount;
						vec4 unused_0_3;
						float _Intensity;
						float _Radius;
						float _Downsample;
						vec3 _FogParams;
					};
					layout(std140) uniform UnityPerCamera {
						vec4 unused_1_0[5];
						vec4 _ProjectionParams;
						vec4 _ScreenParams;
						vec4 _ZBufferParams;
						vec4 unity_OrthoParams;
					};
					layout(std140) uniform UnityPerCameraRare {
						vec4 unused_2_0[6];
						mat4x4 unity_CameraProjection;
						vec4 unused_2_2[12];
					};
					uniform  sampler2D _CameraDepthNormalsTexture;
					uniform  sampler2D _CameraDepthTexture;
					in  vec2 vs_TEXCOORD0;
					in  vec2 vs_TEXCOORD1;
					layout(location = 0) out vec4 SV_Target0;
					vec3 u_xlat0;
					ivec4 u_xlati0;
					bvec2 u_xlatb0;
					vec4 u_xlat1;
					bvec2 u_xlatb1;
					vec3 u_xlat2;
					int u_xlati2;
					bool u_xlatb2;
					vec3 u_xlat3;
					vec2 u_xlat4;
					vec2 u_xlat5;
					vec4 u_xlat6;
					bvec2 u_xlatb6;
					vec2 u_xlat7;
					float u_xlat8;
					bool u_xlatb8;
					float u_xlat9;
					vec3 u_xlat10;
					vec3 u_xlat13;
					bvec2 u_xlatb13;
					float u_xlat16;
					int u_xlati17;
					vec2 u_xlat20;
					float u_xlat24;
					float u_xlat25;
					bool u_xlatb25;
					float u_xlat27;
					int u_xlati27;
					bool u_xlatb27;
					void main()
					{
					    u_xlat0.xy = vs_TEXCOORD0.xy * _CameraDepthTexture_ST.xy + _CameraDepthTexture_ST.zw;
					    u_xlat1 = texture(_CameraDepthNormalsTexture, u_xlat0.xy);
					    u_xlat2.xyz = u_xlat1.xyz * vec3(3.55539989, 3.55539989, 0.0) + vec3(-1.77769995, -1.77769995, 1.0);
					    u_xlat16 = dot(u_xlat2.xyz, u_xlat2.xyz);
					    u_xlat16 = 2.0 / u_xlat16;
					    u_xlat10.xy = u_xlat2.xy * vec2(u_xlat16);
					    u_xlat10.z = u_xlat16 + -1.0;
					    u_xlat3.xyz = u_xlat10.xyz * vec3(1.0, 1.0, -1.0);
					    u_xlat16 = dot(u_xlat1.zw, vec2(1.0, 0.00392156886));
					    u_xlatb1.xy = lessThan(u_xlat0.xyxx, vec4(0.0, 0.0, 0.0, 0.0)).xy;
					    u_xlati0.w = int((uint(u_xlatb1.y) * 0xffffffffu) | (uint(u_xlatb1.x) * 0xffffffffu));
					    u_xlatb0.xy = lessThan(vec4(1.0, 1.0, 0.0, 0.0), u_xlat0.xyxx).xy;
					    u_xlati0.x = int((uint(u_xlatb0.y) * 0xffffffffu) | (uint(u_xlatb0.x) * 0xffffffffu));
					    u_xlati0.xw = ivec2(uvec2(u_xlati0.xw) & uvec2(1u, 1u));
					    u_xlati0.x = u_xlati0.x + u_xlati0.w;
					    u_xlat0.x = float(u_xlati0.x);
					    u_xlatb8 = 9.99999975e-06>=u_xlat16;
					    u_xlat8 = u_xlatb8 ? 1.0 : float(0.0);
					    u_xlat0.x = u_xlat8 + u_xlat0.x;
					    u_xlat0.x = u_xlat0.x * 100000000.0;
					    u_xlat0.x = u_xlat16 * _ProjectionParams.z + u_xlat0.x;
					    u_xlat0.z = (-_ProjectionParams.z) * 1.52587891e-05 + u_xlat0.x;
					    u_xlat1.xy = vs_TEXCOORD1.xy * vec2(2.0, 2.0) + vec2(-1.0, -1.0);
					    u_xlat1.xy = u_xlat1.xy + (-unity_CameraProjection[2].xy);
					    u_xlat4.x = unity_CameraProjection[0].x;
					    u_xlat4.y = unity_CameraProjection[1].y;
					    u_xlat1.xy = u_xlat1.xy / u_xlat4.xy;
					    u_xlat24 = (-u_xlat0.z) + 1.0;
					    u_xlat24 = unity_OrthoParams.w * u_xlat24 + u_xlat0.z;
					    u_xlat0.xy = vec2(u_xlat24) * u_xlat1.xy;
					    u_xlat1.xy = vs_TEXCOORD0.xy * vec2(vec2(_Downsample, _Downsample));
					    u_xlat1.xy = u_xlat1.xy * _ScreenParams.xy;
					    u_xlat1.xy = floor(u_xlat1.xy);
					    u_xlat24 = dot(vec2(0.0671105608, 0.00583714992), u_xlat1.xy);
					    u_xlat24 = fract(u_xlat24);
					    u_xlat24 = u_xlat24 * 52.9829178;
					    u_xlat24 = fract(u_xlat24);
					    u_xlat1.x = float(_SampleCount);
					    u_xlat5.x = 12.9898005;
					    u_xlat9 = float(0.0);
					    for(int u_xlati_loop_1 = int(0) ; u_xlati_loop_1<_SampleCount ; u_xlati_loop_1++)
					    {
					        u_xlat25 = float(u_xlati_loop_1);
					        u_xlat25 = u_xlat25 * 1.00010002;
					        u_xlat25 = floor(u_xlat25);
					        u_xlat5.y = vs_TEXCOORD0.x * 1.00000001e-10 + u_xlat25;
					        u_xlat2.x = u_xlat5.y * 78.2330017;
					        u_xlat2.x = sin(u_xlat2.x);
					        u_xlat2.x = u_xlat2.x * 43758.5469;
					        u_xlat2.x = fract(u_xlat2.x);
					        u_xlat2.x = u_xlat24 + u_xlat2.x;
					        u_xlat2.x = fract(u_xlat2.x);
					        u_xlat6.z = u_xlat2.x * 2.0 + -1.0;
					        u_xlat2.x = dot(u_xlat5.xy, vec2(1.0, 78.2330017));
					        u_xlat2.x = sin(u_xlat2.x);
					        u_xlat2.x = u_xlat2.x * 43758.5469;
					        u_xlat2.x = fract(u_xlat2.x);
					        u_xlat2.x = u_xlat24 + u_xlat2.x;
					        u_xlat2.x = u_xlat2.x * 6.28318548;
					        u_xlat7.x = cos(u_xlat2.x);
					        u_xlat2.x = sin(u_xlat2.x);
					        u_xlat27 = (-u_xlat6.z) * u_xlat6.z + 1.0;
					        u_xlat27 = sqrt(u_xlat27);
					        u_xlat7.y = u_xlat2.x;
					        u_xlat6.xy = vec2(u_xlat27) * u_xlat7.xy;
					        u_xlat25 = u_xlat25 + 1.0;
					        u_xlat25 = u_xlat25 / u_xlat1.x;
					        u_xlat25 = sqrt(u_xlat25);
					        u_xlat25 = u_xlat25 * _Radius;
					        u_xlat13.xyz = vec3(u_xlat25) * u_xlat6.xyz;
					        u_xlat25 = dot((-u_xlat3.xyz), u_xlat13.xyz);
					        u_xlatb25 = u_xlat25>=0.0;
					        u_xlat13.xyz = (bool(u_xlatb25)) ? (-u_xlat13.xyz) : u_xlat13.xyz;
					        u_xlat13.xyz = u_xlat0.xyz + u_xlat13.xyz;
					        u_xlat20.xy = u_xlat13.yy * unity_CameraProjection[1].xy;
					        u_xlat20.xy = unity_CameraProjection[0].xy * u_xlat13.xx + u_xlat20.xy;
					        u_xlat20.xy = unity_CameraProjection[2].xy * u_xlat13.zz + u_xlat20.xy;
					        u_xlat25 = (-u_xlat13.z) + 1.0;
					        u_xlat25 = unity_OrthoParams.w * u_xlat25 + u_xlat13.z;
					        u_xlat20.xy = u_xlat20.xy / vec2(u_xlat25);
					        u_xlat20.xy = u_xlat20.xy + vec2(1.0, 1.0);
					        u_xlat13.xy = u_xlat20.xy * vec2(0.5, 0.5);
					        u_xlat13.xy = u_xlat13.xy * _CameraDepthTexture_ST.xy + _CameraDepthTexture_ST.zw;
					        u_xlat6 = texture(_CameraDepthNormalsTexture, u_xlat13.xy);
					        u_xlat25 = dot(u_xlat6.zw, vec2(1.0, 0.00392156886));
					        u_xlatb6.xy = lessThan(u_xlat13.xyxx, vec4(0.0, 0.0, 0.0, 0.0)).xy;
					        u_xlatb2 = u_xlatb6.y || u_xlatb6.x;
					        u_xlati2 = u_xlatb2 ? 1 : int(0);
					        u_xlatb13.xy = lessThan(vec4(1.0, 1.0, 0.0, 0.0), u_xlat13.xyxx).xy;
					        u_xlatb27 = u_xlatb13.y || u_xlatb13.x;
					        u_xlati27 = u_xlatb27 ? 1 : int(0);
					        u_xlati2 = u_xlati2 + u_xlati27;
					        u_xlat2.x = float(u_xlati2);
					        u_xlatb27 = 9.99999975e-06>=u_xlat25;
					        u_xlat27 = u_xlatb27 ? 1.0 : float(0.0);
					        u_xlat2.x = u_xlat2.x + u_xlat27;
					        u_xlat2.x = u_xlat2.x * 100000000.0;
					        u_xlat6.z = u_xlat25 * _ProjectionParams.z + u_xlat2.x;
					        u_xlat20.xy = u_xlat20.xy + (-unity_CameraProjection[2].xy);
					        u_xlat20.xy = u_xlat20.xy + vec2(-1.0, -1.0);
					        u_xlat20.xy = u_xlat20.xy / u_xlat4.xy;
					        u_xlat25 = (-u_xlat6.z) + 1.0;
					        u_xlat25 = unity_OrthoParams.w * u_xlat25 + u_xlat6.z;
					        u_xlat6.xy = vec2(u_xlat25) * u_xlat20.xy;
					        u_xlat13.xyz = (-u_xlat0.xyz) + u_xlat6.xyz;
					        u_xlat25 = dot(u_xlat13.xyz, u_xlat3.xyz);
					        u_xlat25 = (-u_xlat0.z) * 0.00200000009 + u_xlat25;
					        u_xlat25 = max(u_xlat25, 0.0);
					        u_xlat2.x = dot(u_xlat13.xyz, u_xlat13.xyz);
					        u_xlat2.x = u_xlat2.x + 9.99999975e-05;
					        u_xlat25 = u_xlat25 / u_xlat2.x;
					        u_xlat9 = u_xlat25 + u_xlat9;
					    }
					    u_xlat0.x = u_xlat9 * _Radius;
					    u_xlat0.x = u_xlat0.x * _Intensity;
					    u_xlat0.x = u_xlat0.x / u_xlat1.x;
					    u_xlat0.x = log2(u_xlat0.x);
					    u_xlat0.x = u_xlat0.x * 0.600000024;
					    u_xlat0.x = exp2(u_xlat0.x);
					    u_xlat1 = texture(_CameraDepthTexture, vs_TEXCOORD0.xy);
					    u_xlat8 = _ZBufferParams.x * u_xlat1.x + _ZBufferParams.y;
					    u_xlat8 = float(1.0) / u_xlat8;
					    u_xlat8 = u_xlat8 * _ProjectionParams.z + (-_ProjectionParams.y);
					    u_xlat8 = (-u_xlat8) + _FogParams.z;
					    u_xlat16 = (-_FogParams.y) + _FogParams.z;
					    u_xlat8 = u_xlat8 / u_xlat16;
					    u_xlat8 = clamp(u_xlat8, 0.0, 1.0);
					    SV_Target0.x = u_xlat8 * u_xlat0.x;
					    SV_Target0.yzw = u_xlat10.xyz * vec3(0.5, 0.5, -0.5) + vec3(0.5, 0.5, 0.5);
					    return;
					}"
				}
			}
		}
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 173809
			Program "vp" {
				SubProgram "d3d11 " {
					Keywords { "FOG_OFF" }
					"vs_4_0
					
					#version 330
					#extension GL_ARB_explicit_attrib_location : require
					#extension GL_ARB_explicit_uniform_location : require
					
					#define HLSLCC_ENABLE_UNIFORM_BUFFERS 1
					#if HLSLCC_ENABLE_UNIFORM_BUFFERS
					#define UNITY_UNIFORM
					#else
					#define UNITY_UNIFORM uniform
					#endif
					#define UNITY_SUPPORTS_UNIFORM_LOCATION 1
					#if UNITY_SUPPORTS_UNIFORM_LOCATION
					#define UNITY_LOCATION(x) layout(location = x)
					#define UNITY_BINDING(x) layout(binding = x, std140)
					#else
					#define UNITY_LOCATION(x)
					#define UNITY_BINDING(x) layout(std140)
					#endif
					layout(std140) uniform VGlobals {
						vec4 unused_0_0[2];
						vec4 _MainTex_TexelSize;
						vec4 unused_0_2[6];
					};
					layout(std140) uniform UnityPerDraw {
						mat4x4 unity_ObjectToWorld;
						vec4 unused_1_1[6];
					};
					layout(std140) uniform UnityPerFrame {
						vec4 unused_2_0[17];
						mat4x4 unity_MatrixVP;
						vec4 unused_2_2[2];
					};
					in  vec4 in_POSITION0;
					in  vec4 in_TEXCOORD0;
					out vec2 vs_TEXCOORD0;
					 vec4 phase0_Output0_1;
					out vec2 vs_TEXCOORD1;
					out vec2 vs_TEXCOORD2;
					vec4 u_xlat0;
					bool u_xlatb0;
					vec4 u_xlat1;
					float u_xlat2;
					void main()
					{
					    u_xlat0 = in_POSITION0.yyyy * unity_ObjectToWorld[1];
					    u_xlat0 = unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    u_xlat0 = u_xlat0 + unity_ObjectToWorld[3];
					    u_xlat1 = u_xlat0.yyyy * unity_MatrixVP[1];
					    u_xlat1 = unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
					    u_xlat1 = unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
					    gl_Position = unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
					    u_xlatb0 = _MainTex_TexelSize.y<0.0;
					    u_xlat2 = (-in_TEXCOORD0.y) + 1.0;
					    u_xlat0.w = (u_xlatb0) ? u_xlat2 : in_TEXCOORD0.y;
					    u_xlat0.xyz = in_TEXCOORD0.xyx;
					    phase0_Output0_1 = u_xlat0;
					    vs_TEXCOORD2.xy = u_xlat0.zw;
					vs_TEXCOORD0 = phase0_Output0_1.xy;
					vs_TEXCOORD1 = phase0_Output0_1.zw;
					    return;
					}"
				}
				SubProgram "d3d11 " {
					Keywords { "FOG_LINEAR" }
					"vs_4_0
					
					#version 330
					#extension GL_ARB_explicit_attrib_location : require
					#extension GL_ARB_explicit_uniform_location : require
					
					#define HLSLCC_ENABLE_UNIFORM_BUFFERS 1
					#if HLSLCC_ENABLE_UNIFORM_BUFFERS
					#define UNITY_UNIFORM
					#else
					#define UNITY_UNIFORM uniform
					#endif
					#define UNITY_SUPPORTS_UNIFORM_LOCATION 1
					#if UNITY_SUPPORTS_UNIFORM_LOCATION
					#define UNITY_LOCATION(x) layout(location = x)
					#define UNITY_BINDING(x) layout(binding = x, std140)
					#else
					#define UNITY_LOCATION(x)
					#define UNITY_BINDING(x) layout(std140)
					#endif
					layout(std140) uniform VGlobals {
						vec4 unused_0_0[2];
						vec4 _MainTex_TexelSize;
						vec4 unused_0_2[6];
					};
					layout(std140) uniform UnityPerDraw {
						mat4x4 unity_ObjectToWorld;
						vec4 unused_1_1[6];
					};
					layout(std140) uniform UnityPerFrame {
						vec4 unused_2_0[17];
						mat4x4 unity_MatrixVP;
						vec4 unused_2_2[2];
					};
					in  vec4 in_POSITION0;
					in  vec4 in_TEXCOORD0;
					out vec2 vs_TEXCOORD0;
					 vec4 phase0_Output0_1;
					out vec2 vs_TEXCOORD1;
					out vec2 vs_TEXCOORD2;
					vec4 u_xlat0;
					bool u_xlatb0;
					vec4 u_xlat1;
					float u_xlat2;
					void main()
					{
					    u_xlat0 = in_POSITION0.yyyy * unity_ObjectToWorld[1];
					    u_xlat0 = unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    u_xlat0 = u_xlat0 + unity_ObjectToWorld[3];
					    u_xlat1 = u_xlat0.yyyy * unity_MatrixVP[1];
					    u_xlat1 = unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
					    u_xlat1 = unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
					    gl_Position = unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
					    u_xlatb0 = _MainTex_TexelSize.y<0.0;
					    u_xlat2 = (-in_TEXCOORD0.y) + 1.0;
					    u_xlat0.w = (u_xlatb0) ? u_xlat2 : in_TEXCOORD0.y;
					    u_xlat0.xyz = in_TEXCOORD0.xyx;
					    phase0_Output0_1 = u_xlat0;
					    vs_TEXCOORD2.xy = u_xlat0.zw;
					vs_TEXCOORD0 = phase0_Output0_1.xy;
					vs_TEXCOORD1 = phase0_Output0_1.zw;
					    return;
					}"
				}
			}
			Program "fp" {
				SubProgram "d3d11 " {
					Keywords { "FOG_OFF" }
					"ps_4_0
					
					#version 330
					#extension GL_ARB_explicit_attrib_location : require
					#extension GL_ARB_explicit_uniform_location : require
					
					#define HLSLCC_ENABLE_UNIFORM_BUFFERS 1
					#if HLSLCC_ENABLE_UNIFORM_BUFFERS
					#define UNITY_UNIFORM
					#else
					#define UNITY_UNIFORM uniform
					#endif
					#define UNITY_SUPPORTS_UNIFORM_LOCATION 1
					#if UNITY_SUPPORTS_UNIFORM_LOCATION
					#define UNITY_LOCATION(x) layout(location = x)
					#define UNITY_BINDING(x) layout(binding = x, std140)
					#else
					#define UNITY_LOCATION(x)
					#define UNITY_BINDING(x) layout(std140)
					#endif
					layout(std140) uniform PGlobals {
						vec4 unused_0_0[4];
						vec4 _CameraDepthTexture_ST;
						int _SampleCount;
						vec4 unused_0_3;
						float _Intensity;
						float _Radius;
						float _Downsample;
						vec4 unused_0_7;
					};
					layout(std140) uniform UnityPerCamera {
						vec4 unused_1_0[5];
						vec4 _ProjectionParams;
						vec4 _ScreenParams;
						vec4 _ZBufferParams;
						vec4 unity_OrthoParams;
					};
					layout(std140) uniform UnityPerCameraRare {
						vec4 unused_2_0[6];
						mat4x4 unity_CameraProjection;
						vec4 unused_2_2[4];
						mat4x4 unity_WorldToCamera;
						vec4 unused_2_4[4];
					};
					uniform  sampler2D _CameraGBufferTexture2;
					uniform  sampler2D _CameraDepthTexture;
					in  vec2 vs_TEXCOORD0;
					in  vec2 vs_TEXCOORD1;
					layout(location = 0) out vec4 SV_Target0;
					vec2 u_xlat0;
					int u_xlati0;
					bvec2 u_xlatb0;
					vec4 u_xlat1;
					vec4 u_xlat2;
					bvec2 u_xlatb2;
					vec2 u_xlat3;
					vec2 u_xlat4;
					vec4 u_xlat5;
					bvec2 u_xlatb5;
					float u_xlat6;
					vec2 u_xlat7;
					float u_xlat8;
					bool u_xlatb8;
					vec3 u_xlat12;
					ivec3 u_xlati12;
					bvec2 u_xlatb12;
					float u_xlat16;
					bool u_xlatb16;
					vec2 u_xlat19;
					float u_xlat20;
					bool u_xlatb20;
					float u_xlat24;
					float u_xlat25;
					int u_xlati25;
					bool u_xlatb25;
					float u_xlat26;
					bool u_xlatb26;
					float u_xlat28;
					void main()
					{
					    u_xlat0.xy = vs_TEXCOORD0.xy * _CameraDepthTexture_ST.xy + _CameraDepthTexture_ST.zw;
					    u_xlat1 = texture(_CameraGBufferTexture2, u_xlat0.xy);
					    u_xlat16 = dot(u_xlat1.xyz, u_xlat1.xyz);
					    u_xlatb16 = u_xlat16!=0.0;
					    u_xlat16 = (u_xlatb16) ? -1.0 : -0.0;
					    u_xlat1.xyz = u_xlat1.xyz * vec3(2.0, 2.0, 2.0) + vec3(u_xlat16);
					    u_xlat2.xyz = u_xlat1.yyy * unity_WorldToCamera[1].xyz;
					    u_xlat1.xyw = unity_WorldToCamera[0].xyz * u_xlat1.xxx + u_xlat2.xyz;
					    u_xlat1.xyz = unity_WorldToCamera[2].xyz * u_xlat1.zzz + u_xlat1.xyw;
					    u_xlat2 = texture(_CameraDepthTexture, u_xlat0.xy);
					    u_xlat16 = (-unity_OrthoParams.w) + 1.0;
					    u_xlat24 = u_xlat2.x * _ZBufferParams.x;
					    u_xlat25 = (-unity_OrthoParams.w) * u_xlat24 + 1.0;
					    u_xlat24 = u_xlat16 * u_xlat24 + _ZBufferParams.y;
					    u_xlat24 = u_xlat25 / u_xlat24;
					    u_xlatb2.xy = lessThan(u_xlat0.xyxx, vec4(0.0, 0.0, 0.0, 0.0)).xy;
					    u_xlatb25 = u_xlatb2.y || u_xlatb2.x;
					    u_xlati25 = u_xlatb25 ? 1 : int(0);
					    u_xlatb0.xy = lessThan(vec4(1.0, 1.0, 0.0, 0.0), u_xlat0.xyxx).xy;
					    u_xlatb0.x = u_xlatb0.y || u_xlatb0.x;
					    u_xlati0 = u_xlatb0.x ? 1 : int(0);
					    u_xlati0 = u_xlati0 + u_xlati25;
					    u_xlat0.x = float(u_xlati0);
					    u_xlatb8 = 9.99999975e-06>=u_xlat24;
					    u_xlat8 = u_xlatb8 ? 1.0 : float(0.0);
					    u_xlat0.x = u_xlat8 + u_xlat0.x;
					    u_xlat0.x = u_xlat0.x * 100000000.0;
					    u_xlat2.z = u_xlat24 * _ProjectionParams.z + u_xlat0.x;
					    u_xlat0.xy = vs_TEXCOORD1.xy * vec2(2.0, 2.0) + vec2(-1.0, -1.0);
					    u_xlat0.xy = u_xlat0.xy + (-unity_CameraProjection[2].xy);
					    u_xlat3.x = unity_CameraProjection[0].x;
					    u_xlat3.y = unity_CameraProjection[1].y;
					    u_xlat0.xy = u_xlat0.xy / u_xlat3.xy;
					    u_xlat24 = (-u_xlat2.z) + 1.0;
					    u_xlat24 = unity_OrthoParams.w * u_xlat24 + u_xlat2.z;
					    u_xlat2.xy = vec2(u_xlat24) * u_xlat0.xy;
					    u_xlat0.xy = vs_TEXCOORD0.xy * vec2(vec2(_Downsample, _Downsample));
					    u_xlat0.xy = u_xlat0.xy * _ScreenParams.xy;
					    u_xlat0.xy = floor(u_xlat0.xy);
					    u_xlat0.x = dot(vec2(0.0671105608, 0.00583714992), u_xlat0.xy);
					    u_xlat0.x = fract(u_xlat0.x);
					    u_xlat0.x = u_xlat0.x * 52.9829178;
					    u_xlat0.x = fract(u_xlat0.x);
					    u_xlat8 = float(_SampleCount);
					    u_xlat4.x = 12.9898005;
					    u_xlat24 = 0.0;
					    for(int u_xlati_loop_1 = 0 ; u_xlati_loop_1<_SampleCount ; u_xlati_loop_1++)
					    {
					        u_xlat26 = float(u_xlati_loop_1);
					        u_xlat26 = u_xlat26 * 1.00010002;
					        u_xlat26 = floor(u_xlat26);
					        u_xlat4.y = vs_TEXCOORD0.x * 1.00000001e-10 + u_xlat26;
					        u_xlat19.x = u_xlat4.y * 78.2330017;
					        u_xlat19.x = sin(u_xlat19.x);
					        u_xlat19.x = u_xlat19.x * 43758.5469;
					        u_xlat19.x = fract(u_xlat19.x);
					        u_xlat19.x = u_xlat0.x + u_xlat19.x;
					        u_xlat19.x = fract(u_xlat19.x);
					        u_xlat5.z = u_xlat19.x * 2.0 + -1.0;
					        u_xlat19.x = dot(u_xlat4.xy, vec2(1.0, 78.2330017));
					        u_xlat19.x = sin(u_xlat19.x);
					        u_xlat19.x = u_xlat19.x * 43758.5469;
					        u_xlat19.x = fract(u_xlat19.x);
					        u_xlat19.x = u_xlat0.x + u_xlat19.x;
					        u_xlat19.x = u_xlat19.x * 6.28318548;
					        u_xlat6 = sin(u_xlat19.x);
					        u_xlat7.x = cos(u_xlat19.x);
					        u_xlat19.x = (-u_xlat5.z) * u_xlat5.z + 1.0;
					        u_xlat19.x = sqrt(u_xlat19.x);
					        u_xlat7.y = u_xlat6;
					        u_xlat5.xy = u_xlat19.xx * u_xlat7.xy;
					        u_xlat26 = u_xlat26 + 1.0;
					        u_xlat26 = u_xlat26 / u_xlat8;
					        u_xlat26 = sqrt(u_xlat26);
					        u_xlat26 = u_xlat26 * _Radius;
					        u_xlat12.xyz = vec3(u_xlat26) * u_xlat5.xyz;
					        u_xlat26 = dot((-u_xlat1.xyz), u_xlat12.xyz);
					        u_xlatb26 = u_xlat26>=0.0;
					        u_xlat12.xyz = (bool(u_xlatb26)) ? (-u_xlat12.xyz) : u_xlat12.xyz;
					        u_xlat12.xyz = u_xlat2.xyz + u_xlat12.xyz;
					        u_xlat19.xy = u_xlat12.yy * unity_CameraProjection[1].xy;
					        u_xlat19.xy = unity_CameraProjection[0].xy * u_xlat12.xx + u_xlat19.xy;
					        u_xlat19.xy = unity_CameraProjection[2].xy * u_xlat12.zz + u_xlat19.xy;
					        u_xlat26 = (-u_xlat12.z) + 1.0;
					        u_xlat26 = unity_OrthoParams.w * u_xlat26 + u_xlat12.z;
					        u_xlat19.xy = u_xlat19.xy / vec2(u_xlat26);
					        u_xlat19.xy = u_xlat19.xy + vec2(1.0, 1.0);
					        u_xlat12.xy = u_xlat19.xy * vec2(0.5, 0.5);
					        u_xlat12.xy = u_xlat12.xy * _CameraDepthTexture_ST.xy + _CameraDepthTexture_ST.zw;
					        u_xlat5 = texture(_CameraDepthTexture, u_xlat12.xy);
					        u_xlat26 = u_xlat5.x * _ZBufferParams.x;
					        u_xlat28 = (-unity_OrthoParams.w) * u_xlat26 + 1.0;
					        u_xlat26 = u_xlat16 * u_xlat26 + _ZBufferParams.y;
					        u_xlat26 = u_xlat28 / u_xlat26;
					        u_xlatb5.xy = lessThan(u_xlat12.xyxx, vec4(0.0, 0.0, 0.0, 0.0)).xy;
					        u_xlati12.z = int((uint(u_xlatb5.y) * 0xffffffffu) | (uint(u_xlatb5.x) * 0xffffffffu));
					        u_xlatb12.xy = lessThan(vec4(1.0, 1.0, 0.0, 0.0), u_xlat12.xyxx).xy;
					        u_xlati12.x = int((uint(u_xlatb12.y) * 0xffffffffu) | (uint(u_xlatb12.x) * 0xffffffffu));
					        u_xlati12.xz = ivec2(uvec2(u_xlati12.xz) & uvec2(1u, 1u));
					        u_xlati12.x = u_xlati12.x + u_xlati12.z;
					        u_xlat12.x = float(u_xlati12.x);
					        u_xlatb20 = 9.99999975e-06>=u_xlat26;
					        u_xlat20 = u_xlatb20 ? 1.0 : float(0.0);
					        u_xlat12.x = u_xlat20 + u_xlat12.x;
					        u_xlat12.x = u_xlat12.x * 100000000.0;
					        u_xlat5.z = u_xlat26 * _ProjectionParams.z + u_xlat12.x;
					        u_xlat19.xy = u_xlat19.xy + (-unity_CameraProjection[2].xy);
					        u_xlat19.xy = u_xlat19.xy + vec2(-1.0, -1.0);
					        u_xlat19.xy = u_xlat19.xy / u_xlat3.xy;
					        u_xlat26 = (-u_xlat5.z) + 1.0;
					        u_xlat26 = unity_OrthoParams.w * u_xlat26 + u_xlat5.z;
					        u_xlat5.xy = vec2(u_xlat26) * u_xlat19.xy;
					        u_xlat12.xyz = (-u_xlat2.xyz) + u_xlat5.xyz;
					        u_xlat26 = dot(u_xlat12.xyz, u_xlat1.xyz);
					        u_xlat26 = (-u_xlat2.z) * 0.00200000009 + u_xlat26;
					        u_xlat26 = max(u_xlat26, 0.0);
					        u_xlat19.x = dot(u_xlat12.xyz, u_xlat12.xyz);
					        u_xlat19.x = u_xlat19.x + 9.99999975e-05;
					        u_xlat26 = u_xlat26 / u_xlat19.x;
					        u_xlat24 = u_xlat24 + u_xlat26;
					    }
					    u_xlat0.x = u_xlat24 * _Radius;
					    u_xlat0.x = u_xlat0.x * _Intensity;
					    u_xlat0.x = u_xlat0.x / u_xlat8;
					    u_xlat0.x = log2(u_xlat0.x);
					    u_xlat0.x = u_xlat0.x * 0.600000024;
					    SV_Target0.x = exp2(u_xlat0.x);
					    SV_Target0.yzw = u_xlat1.xyz * vec3(0.5, 0.5, 0.5) + vec3(0.5, 0.5, 0.5);
					    return;
					}"
				}
				SubProgram "d3d11 " {
					Keywords { "FOG_LINEAR" }
					"ps_4_0
					
					#version 330
					#extension GL_ARB_explicit_attrib_location : require
					#extension GL_ARB_explicit_uniform_location : require
					
					#define HLSLCC_ENABLE_UNIFORM_BUFFERS 1
					#if HLSLCC_ENABLE_UNIFORM_BUFFERS
					#define UNITY_UNIFORM
					#else
					#define UNITY_UNIFORM uniform
					#endif
					#define UNITY_SUPPORTS_UNIFORM_LOCATION 1
					#if UNITY_SUPPORTS_UNIFORM_LOCATION
					#define UNITY_LOCATION(x) layout(location = x)
					#define UNITY_BINDING(x) layout(binding = x, std140)
					#else
					#define UNITY_LOCATION(x)
					#define UNITY_BINDING(x) layout(std140)
					#endif
					layout(std140) uniform PGlobals {
						vec4 unused_0_0[4];
						vec4 _CameraDepthTexture_ST;
						int _SampleCount;
						vec4 unused_0_3;
						float _Intensity;
						float _Radius;
						float _Downsample;
						vec3 _FogParams;
					};
					layout(std140) uniform UnityPerCamera {
						vec4 unused_1_0[5];
						vec4 _ProjectionParams;
						vec4 _ScreenParams;
						vec4 _ZBufferParams;
						vec4 unity_OrthoParams;
					};
					layout(std140) uniform UnityPerCameraRare {
						vec4 unused_2_0[6];
						mat4x4 unity_CameraProjection;
						vec4 unused_2_2[4];
						mat4x4 unity_WorldToCamera;
						vec4 unused_2_4[4];
					};
					uniform  sampler2D _CameraGBufferTexture2;
					uniform  sampler2D _CameraDepthTexture;
					in  vec2 vs_TEXCOORD0;
					in  vec2 vs_TEXCOORD1;
					layout(location = 0) out vec4 SV_Target0;
					vec2 u_xlat0;
					int u_xlati0;
					bvec2 u_xlatb0;
					vec4 u_xlat1;
					vec4 u_xlat2;
					bvec2 u_xlatb2;
					vec2 u_xlat3;
					vec2 u_xlat4;
					vec4 u_xlat5;
					bvec2 u_xlatb5;
					float u_xlat6;
					vec2 u_xlat7;
					float u_xlat8;
					bool u_xlatb8;
					vec3 u_xlat12;
					ivec3 u_xlati12;
					bvec2 u_xlatb12;
					float u_xlat16;
					bool u_xlatb16;
					vec2 u_xlat19;
					float u_xlat20;
					bool u_xlatb20;
					float u_xlat24;
					float u_xlat25;
					int u_xlati25;
					bool u_xlatb25;
					float u_xlat26;
					bool u_xlatb26;
					float u_xlat28;
					void main()
					{
					    u_xlat0.xy = vs_TEXCOORD0.xy * _CameraDepthTexture_ST.xy + _CameraDepthTexture_ST.zw;
					    u_xlat1 = texture(_CameraGBufferTexture2, u_xlat0.xy);
					    u_xlat16 = dot(u_xlat1.xyz, u_xlat1.xyz);
					    u_xlatb16 = u_xlat16!=0.0;
					    u_xlat16 = (u_xlatb16) ? -1.0 : -0.0;
					    u_xlat1.xyz = u_xlat1.xyz * vec3(2.0, 2.0, 2.0) + vec3(u_xlat16);
					    u_xlat2.xyz = u_xlat1.yyy * unity_WorldToCamera[1].xyz;
					    u_xlat1.xyw = unity_WorldToCamera[0].xyz * u_xlat1.xxx + u_xlat2.xyz;
					    u_xlat1.xyz = unity_WorldToCamera[2].xyz * u_xlat1.zzz + u_xlat1.xyw;
					    u_xlat2 = texture(_CameraDepthTexture, u_xlat0.xy);
					    u_xlat16 = (-unity_OrthoParams.w) + 1.0;
					    u_xlat24 = u_xlat2.x * _ZBufferParams.x;
					    u_xlat25 = (-unity_OrthoParams.w) * u_xlat24 + 1.0;
					    u_xlat24 = u_xlat16 * u_xlat24 + _ZBufferParams.y;
					    u_xlat24 = u_xlat25 / u_xlat24;
					    u_xlatb2.xy = lessThan(u_xlat0.xyxx, vec4(0.0, 0.0, 0.0, 0.0)).xy;
					    u_xlatb25 = u_xlatb2.y || u_xlatb2.x;
					    u_xlati25 = u_xlatb25 ? 1 : int(0);
					    u_xlatb0.xy = lessThan(vec4(1.0, 1.0, 0.0, 0.0), u_xlat0.xyxx).xy;
					    u_xlatb0.x = u_xlatb0.y || u_xlatb0.x;
					    u_xlati0 = u_xlatb0.x ? 1 : int(0);
					    u_xlati0 = u_xlati0 + u_xlati25;
					    u_xlat0.x = float(u_xlati0);
					    u_xlatb8 = 9.99999975e-06>=u_xlat24;
					    u_xlat8 = u_xlatb8 ? 1.0 : float(0.0);
					    u_xlat0.x = u_xlat8 + u_xlat0.x;
					    u_xlat0.x = u_xlat0.x * 100000000.0;
					    u_xlat2.z = u_xlat24 * _ProjectionParams.z + u_xlat0.x;
					    u_xlat0.xy = vs_TEXCOORD1.xy * vec2(2.0, 2.0) + vec2(-1.0, -1.0);
					    u_xlat0.xy = u_xlat0.xy + (-unity_CameraProjection[2].xy);
					    u_xlat3.x = unity_CameraProjection[0].x;
					    u_xlat3.y = unity_CameraProjection[1].y;
					    u_xlat0.xy = u_xlat0.xy / u_xlat3.xy;
					    u_xlat24 = (-u_xlat2.z) + 1.0;
					    u_xlat24 = unity_OrthoParams.w * u_xlat24 + u_xlat2.z;
					    u_xlat2.xy = vec2(u_xlat24) * u_xlat0.xy;
					    u_xlat0.xy = vs_TEXCOORD0.xy * vec2(vec2(_Downsample, _Downsample));
					    u_xlat0.xy = u_xlat0.xy * _ScreenParams.xy;
					    u_xlat0.xy = floor(u_xlat0.xy);
					    u_xlat0.x = dot(vec2(0.0671105608, 0.00583714992), u_xlat0.xy);
					    u_xlat0.x = fract(u_xlat0.x);
					    u_xlat0.x = u_xlat0.x * 52.9829178;
					    u_xlat0.x = fract(u_xlat0.x);
					    u_xlat8 = float(_SampleCount);
					    u_xlat4.x = 12.9898005;
					    u_xlat24 = 0.0;
					    for(int u_xlati_loop_1 = 0 ; u_xlati_loop_1<_SampleCount ; u_xlati_loop_1++)
					    {
					        u_xlat26 = float(u_xlati_loop_1);
					        u_xlat26 = u_xlat26 * 1.00010002;
					        u_xlat26 = floor(u_xlat26);
					        u_xlat4.y = vs_TEXCOORD0.x * 1.00000001e-10 + u_xlat26;
					        u_xlat19.x = u_xlat4.y * 78.2330017;
					        u_xlat19.x = sin(u_xlat19.x);
					        u_xlat19.x = u_xlat19.x * 43758.5469;
					        u_xlat19.x = fract(u_xlat19.x);
					        u_xlat19.x = u_xlat0.x + u_xlat19.x;
					        u_xlat19.x = fract(u_xlat19.x);
					        u_xlat5.z = u_xlat19.x * 2.0 + -1.0;
					        u_xlat19.x = dot(u_xlat4.xy, vec2(1.0, 78.2330017));
					        u_xlat19.x = sin(u_xlat19.x);
					        u_xlat19.x = u_xlat19.x * 43758.5469;
					        u_xlat19.x = fract(u_xlat19.x);
					        u_xlat19.x = u_xlat0.x + u_xlat19.x;
					        u_xlat19.x = u_xlat19.x * 6.28318548;
					        u_xlat6 = sin(u_xlat19.x);
					        u_xlat7.x = cos(u_xlat19.x);
					        u_xlat19.x = (-u_xlat5.z) * u_xlat5.z + 1.0;
					        u_xlat19.x = sqrt(u_xlat19.x);
					        u_xlat7.y = u_xlat6;
					        u_xlat5.xy = u_xlat19.xx * u_xlat7.xy;
					        u_xlat26 = u_xlat26 + 1.0;
					        u_xlat26 = u_xlat26 / u_xlat8;
					        u_xlat26 = sqrt(u_xlat26);
					        u_xlat26 = u_xlat26 * _Radius;
					        u_xlat12.xyz = vec3(u_xlat26) * u_xlat5.xyz;
					        u_xlat26 = dot((-u_xlat1.xyz), u_xlat12.xyz);
					        u_xlatb26 = u_xlat26>=0.0;
					        u_xlat12.xyz = (bool(u_xlatb26)) ? (-u_xlat12.xyz) : u_xlat12.xyz;
					        u_xlat12.xyz = u_xlat2.xyz + u_xlat12.xyz;
					        u_xlat19.xy = u_xlat12.yy * unity_CameraProjection[1].xy;
					        u_xlat19.xy = unity_CameraProjection[0].xy * u_xlat12.xx + u_xlat19.xy;
					        u_xlat19.xy = unity_CameraProjection[2].xy * u_xlat12.zz + u_xlat19.xy;
					        u_xlat26 = (-u_xlat12.z) + 1.0;
					        u_xlat26 = unity_OrthoParams.w * u_xlat26 + u_xlat12.z;
					        u_xlat19.xy = u_xlat19.xy / vec2(u_xlat26);
					        u_xlat19.xy = u_xlat19.xy + vec2(1.0, 1.0);
					        u_xlat12.xy = u_xlat19.xy * vec2(0.5, 0.5);
					        u_xlat12.xy = u_xlat12.xy * _CameraDepthTexture_ST.xy + _CameraDepthTexture_ST.zw;
					        u_xlat5 = texture(_CameraDepthTexture, u_xlat12.xy);
					        u_xlat26 = u_xlat5.x * _ZBufferParams.x;
					        u_xlat28 = (-unity_OrthoParams.w) * u_xlat26 + 1.0;
					        u_xlat26 = u_xlat16 * u_xlat26 + _ZBufferParams.y;
					        u_xlat26 = u_xlat28 / u_xlat26;
					        u_xlatb5.xy = lessThan(u_xlat12.xyxx, vec4(0.0, 0.0, 0.0, 0.0)).xy;
					        u_xlati12.z = int((uint(u_xlatb5.y) * 0xffffffffu) | (uint(u_xlatb5.x) * 0xffffffffu));
					        u_xlatb12.xy = lessThan(vec4(1.0, 1.0, 0.0, 0.0), u_xlat12.xyxx).xy;
					        u_xlati12.x = int((uint(u_xlatb12.y) * 0xffffffffu) | (uint(u_xlatb12.x) * 0xffffffffu));
					        u_xlati12.xz = ivec2(uvec2(u_xlati12.xz) & uvec2(1u, 1u));
					        u_xlati12.x = u_xlati12.x + u_xlati12.z;
					        u_xlat12.x = float(u_xlati12.x);
					        u_xlatb20 = 9.99999975e-06>=u_xlat26;
					        u_xlat20 = u_xlatb20 ? 1.0 : float(0.0);
					        u_xlat12.x = u_xlat20 + u_xlat12.x;
					        u_xlat12.x = u_xlat12.x * 100000000.0;
					        u_xlat5.z = u_xlat26 * _ProjectionParams.z + u_xlat12.x;
					        u_xlat19.xy = u_xlat19.xy + (-unity_CameraProjection[2].xy);
					        u_xlat19.xy = u_xlat19.xy + vec2(-1.0, -1.0);
					        u_xlat19.xy = u_xlat19.xy / u_xlat3.xy;
					        u_xlat26 = (-u_xlat5.z) + 1.0;
					        u_xlat26 = unity_OrthoParams.w * u_xlat26 + u_xlat5.z;
					        u_xlat5.xy = vec2(u_xlat26) * u_xlat19.xy;
					        u_xlat12.xyz = (-u_xlat2.xyz) + u_xlat5.xyz;
					        u_xlat26 = dot(u_xlat12.xyz, u_xlat1.xyz);
					        u_xlat26 = (-u_xlat2.z) * 0.00200000009 + u_xlat26;
					        u_xlat26 = max(u_xlat26, 0.0);
					        u_xlat19.x = dot(u_xlat12.xyz, u_xlat12.xyz);
					        u_xlat19.x = u_xlat19.x + 9.99999975e-05;
					        u_xlat26 = u_xlat26 / u_xlat19.x;
					        u_xlat24 = u_xlat24 + u_xlat26;
					    }
					    u_xlat0.x = u_xlat24 * _Radius;
					    u_xlat0.x = u_xlat0.x * _Intensity;
					    u_xlat0.x = u_xlat0.x / u_xlat8;
					    u_xlat0.x = log2(u_xlat0.x);
					    u_xlat0.x = u_xlat0.x * 0.600000024;
					    u_xlat0.x = exp2(u_xlat0.x);
					    u_xlat2 = texture(_CameraDepthTexture, vs_TEXCOORD0.xy);
					    u_xlat8 = _ZBufferParams.x * u_xlat2.x + _ZBufferParams.y;
					    u_xlat8 = float(1.0) / u_xlat8;
					    u_xlat8 = u_xlat8 * _ProjectionParams.z + (-_ProjectionParams.y);
					    u_xlat8 = (-u_xlat8) + _FogParams.z;
					    u_xlat16 = (-_FogParams.y) + _FogParams.z;
					    u_xlat8 = u_xlat8 / u_xlat16;
					    u_xlat8 = clamp(u_xlat8, 0.0, 1.0);
					    SV_Target0.x = u_xlat8 * u_xlat0.x;
					    SV_Target0.yzw = u_xlat1.xyz * vec3(0.5, 0.5, 0.5) + vec3(0.5, 0.5, 0.5);
					    return;
					}"
				}
			}
		}
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 216623
			Program "vp" {
				SubProgram "d3d11 " {
					"vs_4_0
					
					#version 330
					#extension GL_ARB_explicit_attrib_location : require
					#extension GL_ARB_explicit_uniform_location : require
					
					#define HLSLCC_ENABLE_UNIFORM_BUFFERS 1
					#if HLSLCC_ENABLE_UNIFORM_BUFFERS
					#define UNITY_UNIFORM
					#else
					#define UNITY_UNIFORM uniform
					#endif
					#define UNITY_SUPPORTS_UNIFORM_LOCATION 1
					#if UNITY_SUPPORTS_UNIFORM_LOCATION
					#define UNITY_LOCATION(x) layout(location = x)
					#define UNITY_BINDING(x) layout(binding = x, std140)
					#else
					#define UNITY_LOCATION(x)
					#define UNITY_BINDING(x) layout(std140)
					#endif
					layout(std140) uniform VGlobals {
						vec4 unused_0_0[2];
						vec4 _MainTex_TexelSize;
						vec4 unused_0_2[6];
					};
					layout(std140) uniform UnityPerDraw {
						mat4x4 unity_ObjectToWorld;
						vec4 unused_1_1[6];
					};
					layout(std140) uniform UnityPerFrame {
						vec4 unused_2_0[17];
						mat4x4 unity_MatrixVP;
						vec4 unused_2_2[2];
					};
					in  vec4 in_POSITION0;
					in  vec4 in_TEXCOORD0;
					out vec2 vs_TEXCOORD0;
					 vec4 phase0_Output0_1;
					out vec2 vs_TEXCOORD1;
					out vec2 vs_TEXCOORD2;
					vec4 u_xlat0;
					bool u_xlatb0;
					vec4 u_xlat1;
					float u_xlat2;
					void main()
					{
					    u_xlat0 = in_POSITION0.yyyy * unity_ObjectToWorld[1];
					    u_xlat0 = unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    u_xlat0 = u_xlat0 + unity_ObjectToWorld[3];
					    u_xlat1 = u_xlat0.yyyy * unity_MatrixVP[1];
					    u_xlat1 = unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
					    u_xlat1 = unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
					    gl_Position = unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
					    u_xlatb0 = _MainTex_TexelSize.y<0.0;
					    u_xlat2 = (-in_TEXCOORD0.y) + 1.0;
					    u_xlat0.w = (u_xlatb0) ? u_xlat2 : in_TEXCOORD0.y;
					    u_xlat0.xyz = in_TEXCOORD0.xyx;
					    phase0_Output0_1 = u_xlat0;
					    vs_TEXCOORD2.xy = u_xlat0.zw;
					vs_TEXCOORD0 = phase0_Output0_1.xy;
					vs_TEXCOORD1 = phase0_Output0_1.zw;
					    return;
					}"
				}
			}
			Program "fp" {
				SubProgram "d3d11 " {
					"ps_4_0
					
					#version 330
					#extension GL_ARB_explicit_attrib_location : require
					#extension GL_ARB_explicit_uniform_location : require
					
					#define HLSLCC_ENABLE_UNIFORM_BUFFERS 1
					#if HLSLCC_ENABLE_UNIFORM_BUFFERS
					#define UNITY_UNIFORM
					#else
					#define UNITY_UNIFORM uniform
					#endif
					#define UNITY_SUPPORTS_UNIFORM_LOCATION 1
					#if UNITY_SUPPORTS_UNIFORM_LOCATION
					#define UNITY_LOCATION(x) layout(location = x)
					#define UNITY_BINDING(x) layout(binding = x, std140)
					#else
					#define UNITY_LOCATION(x)
					#define UNITY_BINDING(x) layout(std140)
					#endif
					layout(std140) uniform PGlobals {
						vec4 unused_0_0[2];
						vec4 _MainTex_TexelSize;
						vec4 unused_0_2[6];
					};
					uniform  sampler2D _MainTex;
					uniform  sampler2D _CameraDepthNormalsTexture;
					in  vec2 vs_TEXCOORD2;
					layout(location = 0) out vec4 SV_Target0;
					vec4 u_xlat0;
					vec4 u_xlat1;
					vec4 u_xlat2;
					vec4 u_xlat3;
					vec4 u_xlat4;
					float u_xlat5;
					vec3 u_xlat6;
					vec3 u_xlat7;
					vec3 u_xlat8;
					float u_xlat10;
					float u_xlat12;
					float u_xlat13;
					float u_xlat15;
					void main()
					{
					    u_xlat0 = texture(_CameraDepthNormalsTexture, vs_TEXCOORD2.xy);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(3.55539989, 3.55539989, 0.0) + vec3(-1.77769995, -1.77769995, 1.0);
					    u_xlat10 = dot(u_xlat0.xyz, u_xlat0.xyz);
					    u_xlat10 = 2.0 / u_xlat10;
					    u_xlat6.xy = u_xlat0.xy * vec2(u_xlat10);
					    u_xlat6.z = u_xlat10 + -1.0;
					    u_xlat0.xyz = u_xlat6.xyz * vec3(1.0, 1.0, -1.0);
					    SV_Target0.yzw = u_xlat6.xyz * vec3(0.5, 0.5, -0.5) + vec3(0.5, 0.5, 0.5);
					    u_xlat1.x = _MainTex_TexelSize.x;
					    u_xlat1.y = 0.0;
					    u_xlat2 = (-u_xlat1.xyxy) * vec4(2.76923084, 1.38461542, 6.46153831, 3.23076916) + vs_TEXCOORD2.xyxy;
					    u_xlat1 = u_xlat1.xyxy * vec4(2.76923084, 1.38461542, 6.46153831, 3.23076916) + vs_TEXCOORD2.xyxy;
					    u_xlat3 = texture(_MainTex, u_xlat2.xy);
					    u_xlat2 = texture(_MainTex, u_xlat2.zw);
					    u_xlat8.xyz = u_xlat3.yzw * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					    u_xlat15 = dot(u_xlat0.xyz, u_xlat8.xyz);
					    u_xlat15 = u_xlat15 + -0.800000012;
					    u_xlat15 = u_xlat15 * 5.00000048;
					    u_xlat15 = clamp(u_xlat15, 0.0, 1.0);
					    u_xlat8.x = u_xlat15 * -2.0 + 3.0;
					    u_xlat15 = u_xlat15 * u_xlat15;
					    u_xlat15 = u_xlat15 * u_xlat8.x;
					    u_xlat15 = u_xlat15 * 0.31621623;
					    u_xlat3.x = u_xlat15 * u_xlat3.x;
					    u_xlat4 = texture(_MainTex, vs_TEXCOORD2.xy);
					    u_xlat3.x = u_xlat4.x * 0.227027029 + u_xlat3.x;
					    u_xlat4 = texture(_MainTex, u_xlat1.xy);
					    u_xlat1 = texture(_MainTex, u_xlat1.zw);
					    u_xlat8.xyz = u_xlat4.yzw * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					    u_xlat8.x = dot(u_xlat0.xyz, u_xlat8.xyz);
					    u_xlat8.x = u_xlat8.x + -0.800000012;
					    u_xlat8.x = u_xlat8.x * 5.00000048;
					    u_xlat8.x = clamp(u_xlat8.x, 0.0, 1.0);
					    u_xlat13 = u_xlat8.x * -2.0 + 3.0;
					    u_xlat8.x = u_xlat8.x * u_xlat8.x;
					    u_xlat8.x = u_xlat8.x * u_xlat13;
					    u_xlat13 = u_xlat8.x * 0.31621623;
					    u_xlat15 = u_xlat8.x * 0.31621623 + u_xlat15;
					    u_xlat3.x = u_xlat4.x * u_xlat13 + u_xlat3.x;
					    u_xlat7.xyz = u_xlat2.yzw * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					    u_xlat7.x = dot(u_xlat0.xyz, u_xlat7.xyz);
					    u_xlat7.x = u_xlat7.x + -0.800000012;
					    u_xlat7.x = u_xlat7.x * 5.00000048;
					    u_xlat7.x = clamp(u_xlat7.x, 0.0, 1.0);
					    u_xlat12 = u_xlat7.x * -2.0 + 3.0;
					    u_xlat7.x = u_xlat7.x * u_xlat7.x;
					    u_xlat7.x = u_xlat7.x * u_xlat12;
					    u_xlat12 = u_xlat7.x * 0.0702702701;
					    u_xlat15 = u_xlat7.x * 0.0702702701 + u_xlat15;
					    u_xlat2.x = u_xlat2.x * u_xlat12 + u_xlat3.x;
					    u_xlat6.xyz = u_xlat1.yzw * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					    u_xlat0.x = dot(u_xlat0.xyz, u_xlat6.xyz);
					    u_xlat0.x = u_xlat0.x + -0.800000012;
					    u_xlat0.x = u_xlat0.x * 5.00000048;
					    u_xlat0.x = clamp(u_xlat0.x, 0.0, 1.0);
					    u_xlat5 = u_xlat0.x * -2.0 + 3.0;
					    u_xlat0.x = u_xlat0.x * u_xlat0.x;
					    u_xlat0.x = u_xlat0.x * u_xlat5;
					    u_xlat5 = u_xlat0.x * 0.0702702701;
					    u_xlat0.x = u_xlat0.x * 0.0702702701 + u_xlat15;
					    u_xlat0.x = u_xlat0.x + 0.227027029;
					    u_xlat5 = u_xlat1.x * u_xlat5 + u_xlat2.x;
					    SV_Target0.x = u_xlat5 / u_xlat0.x;
					    return;
					}"
				}
			}
		}
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 275137
			Program "vp" {
				SubProgram "d3d11 " {
					"vs_4_0
					
					#version 330
					#extension GL_ARB_explicit_attrib_location : require
					#extension GL_ARB_explicit_uniform_location : require
					
					#define HLSLCC_ENABLE_UNIFORM_BUFFERS 1
					#if HLSLCC_ENABLE_UNIFORM_BUFFERS
					#define UNITY_UNIFORM
					#else
					#define UNITY_UNIFORM uniform
					#endif
					#define UNITY_SUPPORTS_UNIFORM_LOCATION 1
					#if UNITY_SUPPORTS_UNIFORM_LOCATION
					#define UNITY_LOCATION(x) layout(location = x)
					#define UNITY_BINDING(x) layout(binding = x, std140)
					#else
					#define UNITY_LOCATION(x)
					#define UNITY_BINDING(x) layout(std140)
					#endif
					layout(std140) uniform VGlobals {
						vec4 unused_0_0[2];
						vec4 _MainTex_TexelSize;
						vec4 unused_0_2[6];
					};
					layout(std140) uniform UnityPerDraw {
						mat4x4 unity_ObjectToWorld;
						vec4 unused_1_1[6];
					};
					layout(std140) uniform UnityPerFrame {
						vec4 unused_2_0[17];
						mat4x4 unity_MatrixVP;
						vec4 unused_2_2[2];
					};
					in  vec4 in_POSITION0;
					in  vec4 in_TEXCOORD0;
					out vec2 vs_TEXCOORD0;
					 vec4 phase0_Output0_1;
					out vec2 vs_TEXCOORD1;
					out vec2 vs_TEXCOORD2;
					vec4 u_xlat0;
					bool u_xlatb0;
					vec4 u_xlat1;
					float u_xlat2;
					void main()
					{
					    u_xlat0 = in_POSITION0.yyyy * unity_ObjectToWorld[1];
					    u_xlat0 = unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    u_xlat0 = u_xlat0 + unity_ObjectToWorld[3];
					    u_xlat1 = u_xlat0.yyyy * unity_MatrixVP[1];
					    u_xlat1 = unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
					    u_xlat1 = unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
					    gl_Position = unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
					    u_xlatb0 = _MainTex_TexelSize.y<0.0;
					    u_xlat2 = (-in_TEXCOORD0.y) + 1.0;
					    u_xlat0.w = (u_xlatb0) ? u_xlat2 : in_TEXCOORD0.y;
					    u_xlat0.xyz = in_TEXCOORD0.xyx;
					    phase0_Output0_1 = u_xlat0;
					    vs_TEXCOORD2.xy = u_xlat0.zw;
					vs_TEXCOORD0 = phase0_Output0_1.xy;
					vs_TEXCOORD1 = phase0_Output0_1.zw;
					    return;
					}"
				}
			}
			Program "fp" {
				SubProgram "d3d11 " {
					"ps_4_0
					
					#version 330
					#extension GL_ARB_explicit_attrib_location : require
					#extension GL_ARB_explicit_uniform_location : require
					
					#define HLSLCC_ENABLE_UNIFORM_BUFFERS 1
					#if HLSLCC_ENABLE_UNIFORM_BUFFERS
					#define UNITY_UNIFORM
					#else
					#define UNITY_UNIFORM uniform
					#endif
					#define UNITY_SUPPORTS_UNIFORM_LOCATION 1
					#if UNITY_SUPPORTS_UNIFORM_LOCATION
					#define UNITY_LOCATION(x) layout(location = x)
					#define UNITY_BINDING(x) layout(binding = x, std140)
					#else
					#define UNITY_LOCATION(x)
					#define UNITY_BINDING(x) layout(std140)
					#endif
					layout(std140) uniform PGlobals {
						vec4 unused_0_0[2];
						vec4 _MainTex_TexelSize;
						vec4 unused_0_2[6];
					};
					layout(std140) uniform UnityPerCameraRare {
						vec4 unused_1_0[14];
						mat4x4 unity_WorldToCamera;
						vec4 unused_1_2[4];
					};
					uniform  sampler2D _MainTex;
					uniform  sampler2D _CameraGBufferTexture2;
					in  vec2 vs_TEXCOORD2;
					layout(location = 0) out vec4 SV_Target0;
					vec4 u_xlat0;
					vec4 u_xlat1;
					vec4 u_xlat2;
					vec4 u_xlat3;
					vec4 u_xlat4;
					float u_xlat5;
					vec3 u_xlat6;
					vec3 u_xlat7;
					vec3 u_xlat8;
					float u_xlat12;
					float u_xlat13;
					float u_xlat15;
					bool u_xlatb15;
					void main()
					{
					    u_xlat0 = texture(_CameraGBufferTexture2, vs_TEXCOORD2.xy);
					    u_xlat15 = dot(u_xlat0.xyz, u_xlat0.xyz);
					    u_xlatb15 = u_xlat15!=0.0;
					    u_xlat15 = (u_xlatb15) ? -1.0 : -0.0;
					    u_xlat0.xyz = u_xlat0.xyz * vec3(2.0, 2.0, 2.0) + vec3(u_xlat15);
					    u_xlat1.xyz = u_xlat0.yyy * unity_WorldToCamera[1].xyz;
					    u_xlat0.xyw = unity_WorldToCamera[0].xyz * u_xlat0.xxx + u_xlat1.xyz;
					    u_xlat0.xyz = unity_WorldToCamera[2].xyz * u_xlat0.zzz + u_xlat0.xyw;
					    u_xlat1.x = _MainTex_TexelSize.x;
					    u_xlat1.y = 0.0;
					    u_xlat2 = (-u_xlat1.xyxy) * vec4(2.76923084, 1.38461542, 6.46153831, 3.23076916) + vs_TEXCOORD2.xyxy;
					    u_xlat1 = u_xlat1.xyxy * vec4(2.76923084, 1.38461542, 6.46153831, 3.23076916) + vs_TEXCOORD2.xyxy;
					    u_xlat3 = texture(_MainTex, u_xlat2.xy);
					    u_xlat2 = texture(_MainTex, u_xlat2.zw);
					    u_xlat8.xyz = u_xlat3.yzw * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					    u_xlat15 = dot(u_xlat0.xyz, u_xlat8.xyz);
					    u_xlat15 = u_xlat15 + -0.800000012;
					    u_xlat15 = u_xlat15 * 5.00000048;
					    u_xlat15 = clamp(u_xlat15, 0.0, 1.0);
					    u_xlat8.x = u_xlat15 * -2.0 + 3.0;
					    u_xlat15 = u_xlat15 * u_xlat15;
					    u_xlat15 = u_xlat15 * u_xlat8.x;
					    u_xlat15 = u_xlat15 * 0.31621623;
					    u_xlat3.x = u_xlat15 * u_xlat3.x;
					    u_xlat4 = texture(_MainTex, vs_TEXCOORD2.xy);
					    u_xlat3.x = u_xlat4.x * 0.227027029 + u_xlat3.x;
					    u_xlat4 = texture(_MainTex, u_xlat1.xy);
					    u_xlat1 = texture(_MainTex, u_xlat1.zw);
					    u_xlat8.xyz = u_xlat4.yzw * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					    u_xlat8.x = dot(u_xlat0.xyz, u_xlat8.xyz);
					    u_xlat8.x = u_xlat8.x + -0.800000012;
					    u_xlat8.x = u_xlat8.x * 5.00000048;
					    u_xlat8.x = clamp(u_xlat8.x, 0.0, 1.0);
					    u_xlat13 = u_xlat8.x * -2.0 + 3.0;
					    u_xlat8.x = u_xlat8.x * u_xlat8.x;
					    u_xlat8.x = u_xlat8.x * u_xlat13;
					    u_xlat13 = u_xlat8.x * 0.31621623;
					    u_xlat15 = u_xlat8.x * 0.31621623 + u_xlat15;
					    u_xlat3.x = u_xlat4.x * u_xlat13 + u_xlat3.x;
					    u_xlat7.xyz = u_xlat2.yzw * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					    u_xlat7.x = dot(u_xlat0.xyz, u_xlat7.xyz);
					    u_xlat7.x = u_xlat7.x + -0.800000012;
					    u_xlat7.x = u_xlat7.x * 5.00000048;
					    u_xlat7.x = clamp(u_xlat7.x, 0.0, 1.0);
					    u_xlat12 = u_xlat7.x * -2.0 + 3.0;
					    u_xlat7.x = u_xlat7.x * u_xlat7.x;
					    u_xlat7.x = u_xlat7.x * u_xlat12;
					    u_xlat12 = u_xlat7.x * 0.0702702701;
					    u_xlat15 = u_xlat7.x * 0.0702702701 + u_xlat15;
					    u_xlat2.x = u_xlat2.x * u_xlat12 + u_xlat3.x;
					    u_xlat6.xyz = u_xlat1.yzw * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					    u_xlat6.x = dot(u_xlat0.xyz, u_xlat6.xyz);
					    SV_Target0.yzw = u_xlat0.xyz * vec3(0.5, 0.5, 0.5) + vec3(0.5, 0.5, 0.5);
					    u_xlat0.x = u_xlat6.x + -0.800000012;
					    u_xlat0.x = u_xlat0.x * 5.00000048;
					    u_xlat0.x = clamp(u_xlat0.x, 0.0, 1.0);
					    u_xlat5 = u_xlat0.x * -2.0 + 3.0;
					    u_xlat0.x = u_xlat0.x * u_xlat0.x;
					    u_xlat0.x = u_xlat0.x * u_xlat5;
					    u_xlat5 = u_xlat0.x * 0.0702702701;
					    u_xlat0.x = u_xlat0.x * 0.0702702701 + u_xlat15;
					    u_xlat0.x = u_xlat0.x + 0.227027029;
					    u_xlat5 = u_xlat1.x * u_xlat5 + u_xlat2.x;
					    SV_Target0.x = u_xlat5 / u_xlat0.x;
					    return;
					}"
				}
			}
		}
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 359305
			Program "vp" {
				SubProgram "d3d11 " {
					"vs_4_0
					
					#version 330
					#extension GL_ARB_explicit_attrib_location : require
					#extension GL_ARB_explicit_uniform_location : require
					
					#define HLSLCC_ENABLE_UNIFORM_BUFFERS 1
					#if HLSLCC_ENABLE_UNIFORM_BUFFERS
					#define UNITY_UNIFORM
					#else
					#define UNITY_UNIFORM uniform
					#endif
					#define UNITY_SUPPORTS_UNIFORM_LOCATION 1
					#if UNITY_SUPPORTS_UNIFORM_LOCATION
					#define UNITY_LOCATION(x) layout(location = x)
					#define UNITY_BINDING(x) layout(binding = x, std140)
					#else
					#define UNITY_LOCATION(x)
					#define UNITY_BINDING(x) layout(std140)
					#endif
					layout(std140) uniform VGlobals {
						vec4 unused_0_0[2];
						vec4 _MainTex_TexelSize;
						vec4 unused_0_2[6];
					};
					layout(std140) uniform UnityPerDraw {
						mat4x4 unity_ObjectToWorld;
						vec4 unused_1_1[6];
					};
					layout(std140) uniform UnityPerFrame {
						vec4 unused_2_0[17];
						mat4x4 unity_MatrixVP;
						vec4 unused_2_2[2];
					};
					in  vec4 in_POSITION0;
					in  vec4 in_TEXCOORD0;
					out vec2 vs_TEXCOORD0;
					 vec4 phase0_Output0_1;
					out vec2 vs_TEXCOORD1;
					out vec2 vs_TEXCOORD2;
					vec4 u_xlat0;
					bool u_xlatb0;
					vec4 u_xlat1;
					float u_xlat2;
					void main()
					{
					    u_xlat0 = in_POSITION0.yyyy * unity_ObjectToWorld[1];
					    u_xlat0 = unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    u_xlat0 = u_xlat0 + unity_ObjectToWorld[3];
					    u_xlat1 = u_xlat0.yyyy * unity_MatrixVP[1];
					    u_xlat1 = unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
					    u_xlat1 = unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
					    gl_Position = unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
					    u_xlatb0 = _MainTex_TexelSize.y<0.0;
					    u_xlat2 = (-in_TEXCOORD0.y) + 1.0;
					    u_xlat0.w = (u_xlatb0) ? u_xlat2 : in_TEXCOORD0.y;
					    u_xlat0.xyz = in_TEXCOORD0.xyx;
					    phase0_Output0_1 = u_xlat0;
					    vs_TEXCOORD2.xy = u_xlat0.zw;
					vs_TEXCOORD0 = phase0_Output0_1.xy;
					vs_TEXCOORD1 = phase0_Output0_1.zw;
					    return;
					}"
				}
			}
			Program "fp" {
				SubProgram "d3d11 " {
					"ps_4_0
					
					#version 330
					#extension GL_ARB_explicit_attrib_location : require
					#extension GL_ARB_explicit_uniform_location : require
					
					#define HLSLCC_ENABLE_UNIFORM_BUFFERS 1
					#if HLSLCC_ENABLE_UNIFORM_BUFFERS
					#define UNITY_UNIFORM
					#else
					#define UNITY_UNIFORM uniform
					#endif
					#define UNITY_SUPPORTS_UNIFORM_LOCATION 1
					#if UNITY_SUPPORTS_UNIFORM_LOCATION
					#define UNITY_LOCATION(x) layout(location = x)
					#define UNITY_BINDING(x) layout(binding = x, std140)
					#else
					#define UNITY_LOCATION(x)
					#define UNITY_BINDING(x) layout(std140)
					#endif
					layout(std140) uniform PGlobals {
						vec4 unused_0_0[2];
						vec4 _MainTex_TexelSize;
						vec4 unused_0_2[4];
						float _Downsample;
						vec4 unused_0_4;
					};
					uniform  sampler2D _MainTex;
					in  vec2 vs_TEXCOORD2;
					layout(location = 0) out vec4 SV_Target0;
					vec4 u_xlat0;
					vec4 u_xlat1;
					vec4 u_xlat2;
					vec4 u_xlat3;
					vec4 u_xlat4;
					vec3 u_xlat5;
					vec3 u_xlat6;
					vec3 u_xlat7;
					vec3 u_xlat8;
					vec3 u_xlat9;
					float u_xlat10;
					float u_xlat11;
					float u_xlat12;
					float u_xlat17;
					void main()
					{
					    u_xlat0.x = _MainTex_TexelSize.y / _Downsample;
					    u_xlat0.y = float(1.38461542);
					    u_xlat0.z = float(3.23076916);
					    u_xlat1 = vec4(-0.0, -2.76923084, -0.0, -6.46153831) * u_xlat0.yxzx + vs_TEXCOORD2.xyxy;
					    u_xlat0 = vec4(0.0, 2.76923084, 0.0, 6.46153831) * u_xlat0.yxzx + vs_TEXCOORD2.xyxy;
					    u_xlat2 = texture(_MainTex, u_xlat1.xy);
					    u_xlat1 = texture(_MainTex, u_xlat1.zw);
					    u_xlat7.xyz = u_xlat2.yzw * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					    u_xlat3 = texture(_MainTex, vs_TEXCOORD2.xy);
					    u_xlat8.xyz = u_xlat3.yzw * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					    u_xlat7.x = dot(u_xlat8.xyz, u_xlat7.xyz);
					    u_xlat7.x = u_xlat7.x + -0.800000012;
					    u_xlat7.x = u_xlat7.x * 5.00000048;
					    u_xlat7.x = clamp(u_xlat7.x, 0.0, 1.0);
					    u_xlat12 = u_xlat7.x * -2.0 + 3.0;
					    u_xlat7.x = u_xlat7.x * u_xlat7.x;
					    u_xlat7.x = u_xlat7.x * u_xlat12;
					    u_xlat7.x = u_xlat7.x * 0.31621623;
					    u_xlat2.x = u_xlat7.x * u_xlat2.x;
					    u_xlat2.x = u_xlat3.x * 0.227027029 + u_xlat2.x;
					    u_xlat4 = texture(_MainTex, u_xlat0.xy);
					    u_xlat0 = texture(_MainTex, u_xlat0.zw);
					    u_xlat9.xyz = u_xlat4.yzw * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					    u_xlat12 = dot(u_xlat8.xyz, u_xlat9.xyz);
					    u_xlat12 = u_xlat12 + -0.800000012;
					    u_xlat12 = u_xlat12 * 5.00000048;
					    u_xlat12 = clamp(u_xlat12, 0.0, 1.0);
					    u_xlat17 = u_xlat12 * -2.0 + 3.0;
					    u_xlat12 = u_xlat12 * u_xlat12;
					    u_xlat12 = u_xlat12 * u_xlat17;
					    u_xlat17 = u_xlat12 * 0.31621623;
					    u_xlat7.x = u_xlat12 * 0.31621623 + u_xlat7.x;
					    u_xlat2.x = u_xlat4.x * u_xlat17 + u_xlat2.x;
					    u_xlat6.xyz = u_xlat1.yzw * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					    u_xlat6.x = dot(u_xlat8.xyz, u_xlat6.xyz);
					    u_xlat6.x = u_xlat6.x + -0.800000012;
					    u_xlat6.x = u_xlat6.x * 5.00000048;
					    u_xlat6.x = clamp(u_xlat6.x, 0.0, 1.0);
					    u_xlat11 = u_xlat6.x * -2.0 + 3.0;
					    u_xlat6.x = u_xlat6.x * u_xlat6.x;
					    u_xlat6.x = u_xlat6.x * u_xlat11;
					    u_xlat11 = u_xlat6.x * 0.0702702701;
					    u_xlat6.x = u_xlat6.x * 0.0702702701 + u_xlat7.x;
					    u_xlat1.x = u_xlat1.x * u_xlat11 + u_xlat2.x;
					    u_xlat5.xyz = u_xlat0.yzw * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					    u_xlat5.x = dot(u_xlat8.xyz, u_xlat5.xyz);
					    SV_Target0.yzw = u_xlat8.xyz * vec3(0.5, 0.5, 0.5) + vec3(0.5, 0.5, 0.5);
					    u_xlat5.x = u_xlat5.x + -0.800000012;
					    u_xlat5.x = u_xlat5.x * 5.00000048;
					    u_xlat5.x = clamp(u_xlat5.x, 0.0, 1.0);
					    u_xlat10 = u_xlat5.x * -2.0 + 3.0;
					    u_xlat5.x = u_xlat5.x * u_xlat5.x;
					    u_xlat5.x = u_xlat5.x * u_xlat10;
					    u_xlat10 = u_xlat5.x * 0.0702702701;
					    u_xlat5.x = u_xlat5.x * 0.0702702701 + u_xlat6.x;
					    u_xlat5.x = u_xlat5.x + 0.227027029;
					    u_xlat0.x = u_xlat0.x * u_xlat10 + u_xlat1.x;
					    SV_Target0.x = u_xlat0.x / u_xlat5.x;
					    return;
					}"
				}
			}
		}
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 456209
			Program "vp" {
				SubProgram "d3d11 " {
					"vs_4_0
					
					#version 330
					#extension GL_ARB_explicit_attrib_location : require
					#extension GL_ARB_explicit_uniform_location : require
					
					#define HLSLCC_ENABLE_UNIFORM_BUFFERS 1
					#if HLSLCC_ENABLE_UNIFORM_BUFFERS
					#define UNITY_UNIFORM
					#else
					#define UNITY_UNIFORM uniform
					#endif
					#define UNITY_SUPPORTS_UNIFORM_LOCATION 1
					#if UNITY_SUPPORTS_UNIFORM_LOCATION
					#define UNITY_LOCATION(x) layout(location = x)
					#define UNITY_BINDING(x) layout(binding = x, std140)
					#else
					#define UNITY_LOCATION(x)
					#define UNITY_BINDING(x) layout(std140)
					#endif
					layout(std140) uniform VGlobals {
						vec4 unused_0_0[2];
						vec4 _MainTex_TexelSize;
						vec4 unused_0_2[6];
					};
					layout(std140) uniform UnityPerDraw {
						mat4x4 unity_ObjectToWorld;
						vec4 unused_1_1[6];
					};
					layout(std140) uniform UnityPerFrame {
						vec4 unused_2_0[17];
						mat4x4 unity_MatrixVP;
						vec4 unused_2_2[2];
					};
					in  vec4 in_POSITION0;
					in  vec4 in_TEXCOORD0;
					out vec2 vs_TEXCOORD0;
					 vec4 phase0_Output0_1;
					out vec2 vs_TEXCOORD1;
					out vec2 vs_TEXCOORD2;
					vec4 u_xlat0;
					bool u_xlatb0;
					vec4 u_xlat1;
					float u_xlat2;
					void main()
					{
					    u_xlat0 = in_POSITION0.yyyy * unity_ObjectToWorld[1];
					    u_xlat0 = unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    u_xlat0 = u_xlat0 + unity_ObjectToWorld[3];
					    u_xlat1 = u_xlat0.yyyy * unity_MatrixVP[1];
					    u_xlat1 = unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
					    u_xlat1 = unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
					    gl_Position = unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
					    u_xlatb0 = _MainTex_TexelSize.y<0.0;
					    u_xlat2 = (-in_TEXCOORD0.y) + 1.0;
					    u_xlat0.w = (u_xlatb0) ? u_xlat2 : in_TEXCOORD0.y;
					    u_xlat0.xyz = in_TEXCOORD0.xyx;
					    phase0_Output0_1 = u_xlat0;
					    vs_TEXCOORD2.xy = u_xlat0.zw;
					vs_TEXCOORD0 = phase0_Output0_1.xy;
					vs_TEXCOORD1 = phase0_Output0_1.zw;
					    return;
					}"
				}
			}
			Program "fp" {
				SubProgram "d3d11 " {
					"ps_4_0
					
					#version 330
					#extension GL_ARB_explicit_attrib_location : require
					#extension GL_ARB_explicit_uniform_location : require
					
					#define HLSLCC_ENABLE_UNIFORM_BUFFERS 1
					#if HLSLCC_ENABLE_UNIFORM_BUFFERS
					#define UNITY_UNIFORM
					#else
					#define UNITY_UNIFORM uniform
					#endif
					#define UNITY_SUPPORTS_UNIFORM_LOCATION 1
					#if UNITY_SUPPORTS_UNIFORM_LOCATION
					#define UNITY_LOCATION(x) layout(location = x)
					#define UNITY_BINDING(x) layout(binding = x, std140)
					#else
					#define UNITY_LOCATION(x)
					#define UNITY_BINDING(x) layout(std140)
					#endif
					layout(std140) uniform PGlobals {
						vec4 unused_0_0[2];
						vec4 _MainTex_TexelSize;
						vec4 unused_0_2[4];
						float _Downsample;
						vec4 unused_0_4;
					};
					uniform  sampler2D _OcclusionTexture;
					uniform  sampler2D _MainTex;
					in  vec2 vs_TEXCOORD2;
					layout(location = 0) out vec4 SV_Target0;
					vec4 u_xlat0;
					vec4 u_xlat1;
					vec4 u_xlat2;
					vec4 u_xlat3;
					vec4 u_xlat4;
					vec3 u_xlat5;
					vec3 u_xlat6;
					vec3 u_xlat7;
					vec3 u_xlat8;
					vec3 u_xlat9;
					float u_xlat10;
					float u_xlat11;
					float u_xlat15;
					float u_xlat16;
					void main()
					{
					    u_xlat0.xy = _MainTex_TexelSize.xy / vec2(vec2(_Downsample, _Downsample));
					    u_xlat1.xy = (-u_xlat0.xy) + vs_TEXCOORD2.xy;
					    u_xlat1 = texture(_OcclusionTexture, u_xlat1.xy);
					    u_xlat6.xyz = u_xlat1.yzw * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					    u_xlat2 = texture(_OcclusionTexture, vs_TEXCOORD2.xy);
					    u_xlat7.xyz = u_xlat2.yzw * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					    u_xlat6.x = dot(u_xlat7.xyz, u_xlat6.xyz);
					    u_xlat6.x = u_xlat6.x + -0.800000012;
					    u_xlat6.x = u_xlat6.x * 5.00000048;
					    u_xlat6.x = clamp(u_xlat6.x, 0.0, 1.0);
					    u_xlat11 = u_xlat6.x * -2.0 + 3.0;
					    u_xlat6.x = u_xlat6.x * u_xlat6.x;
					    u_xlat6.x = u_xlat6.x * u_xlat11;
					    u_xlat1.x = u_xlat1.x * u_xlat6.x + u_xlat2.x;
					    u_xlat0.zw = (-u_xlat0.yx);
					    u_xlat3 = u_xlat0.xzwy + vs_TEXCOORD2.xyxy;
					    u_xlat0.xy = u_xlat0.xy + vs_TEXCOORD2.xy;
					    u_xlat0 = texture(_OcclusionTexture, u_xlat0.xy);
					    u_xlat4 = texture(_OcclusionTexture, u_xlat3.xy);
					    u_xlat3 = texture(_OcclusionTexture, u_xlat3.zw);
					    u_xlat9.xyz = u_xlat4.yzw * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					    u_xlat11 = dot(u_xlat7.xyz, u_xlat9.xyz);
					    u_xlat11 = u_xlat11 + -0.800000012;
					    u_xlat11 = u_xlat11 * 5.00000048;
					    u_xlat11 = clamp(u_xlat11, 0.0, 1.0);
					    u_xlat16 = u_xlat11 * -2.0 + 3.0;
					    u_xlat11 = u_xlat11 * u_xlat11;
					    u_xlat2.x = u_xlat11 * u_xlat16;
					    u_xlat6.x = u_xlat16 * u_xlat11 + u_xlat6.x;
					    u_xlat1.x = u_xlat4.x * u_xlat2.x + u_xlat1.x;
					    u_xlat8.xyz = u_xlat3.yzw * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					    u_xlat11 = dot(u_xlat7.xyz, u_xlat8.xyz);
					    u_xlat11 = u_xlat11 + -0.800000012;
					    u_xlat11 = u_xlat11 * 5.00000048;
					    u_xlat11 = clamp(u_xlat11, 0.0, 1.0);
					    u_xlat16 = u_xlat11 * -2.0 + 3.0;
					    u_xlat11 = u_xlat11 * u_xlat11;
					    u_xlat2.x = u_xlat11 * u_xlat16;
					    u_xlat6.x = u_xlat16 * u_xlat11 + u_xlat6.x;
					    u_xlat1.x = u_xlat3.x * u_xlat2.x + u_xlat1.x;
					    u_xlat5.xyz = u_xlat0.yzw * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					    u_xlat5.x = dot(u_xlat7.xyz, u_xlat5.xyz);
					    u_xlat5.x = u_xlat5.x + -0.800000012;
					    u_xlat5.x = u_xlat5.x * 5.00000048;
					    u_xlat5.x = clamp(u_xlat5.x, 0.0, 1.0);
					    u_xlat10 = u_xlat5.x * -2.0 + 3.0;
					    u_xlat5.x = u_xlat5.x * u_xlat5.x;
					    u_xlat15 = u_xlat5.x * u_xlat10;
					    u_xlat5.x = u_xlat10 * u_xlat5.x + u_xlat6.x;
					    u_xlat5.x = u_xlat5.x + 1.0;
					    u_xlat0.x = u_xlat0.x * u_xlat15 + u_xlat1.x;
					    u_xlat0.x = u_xlat0.x / u_xlat5.x;
					    u_xlat0.x = (-u_xlat0.x) + 1.0;
					    u_xlat0.x = log2(u_xlat0.x);
					    u_xlat0.x = u_xlat0.x * 0.416666657;
					    u_xlat0.x = exp2(u_xlat0.x);
					    u_xlat0.x = u_xlat0.x * 1.05499995 + -0.0549999997;
					    u_xlat0.x = max(u_xlat0.x, 0.0);
					    u_xlat0.x = (-u_xlat0.x) + 1.0;
					    u_xlat0.x = (-u_xlat0.x) + 1.0;
					    u_xlat1 = texture(_MainTex, vs_TEXCOORD2.xy);
					    SV_Target0.xyz = u_xlat0.xxx * u_xlat1.xyz;
					    SV_Target0.w = u_xlat1.w;
					    return;
					}"
				}
			}
		}
		Pass {
			Blend Zero OneMinusSrcColor, Zero OneMinusSrcAlpha
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 458886
			Program "vp" {
				SubProgram "d3d11 " {
					"vs_4_0
					
					#version 330
					#extension GL_ARB_explicit_attrib_location : require
					#extension GL_ARB_explicit_uniform_location : require
					
					in  vec4 in_POSITION0;
					in  vec4 in_TEXCOORD0;
					out vec2 vs_TEXCOORD0;
					 vec4 phase0_Output0_1;
					out vec2 vs_TEXCOORD1;
					void main()
					{
					    gl_Position = in_POSITION0;
					    phase0_Output0_1 = in_TEXCOORD0.xyxy * vec4(1.0, -1.0, 1.0, -1.0) + vec4(0.0, 1.0, 0.0, 1.0);
					vs_TEXCOORD0 = phase0_Output0_1.xy;
					vs_TEXCOORD1 = phase0_Output0_1.zw;
					    return;
					}"
				}
			}
			Program "fp" {
				SubProgram "d3d11 " {
					"ps_4_0
					
					#version 330
					#extension GL_ARB_explicit_attrib_location : require
					#extension GL_ARB_explicit_uniform_location : require
					
					#define HLSLCC_ENABLE_UNIFORM_BUFFERS 1
					#if HLSLCC_ENABLE_UNIFORM_BUFFERS
					#define UNITY_UNIFORM
					#else
					#define UNITY_UNIFORM uniform
					#endif
					#define UNITY_SUPPORTS_UNIFORM_LOCATION 1
					#if UNITY_SUPPORTS_UNIFORM_LOCATION
					#define UNITY_LOCATION(x) layout(location = x)
					#define UNITY_BINDING(x) layout(binding = x, std140)
					#else
					#define UNITY_LOCATION(x)
					#define UNITY_BINDING(x) layout(std140)
					#endif
					layout(std140) uniform PGlobals {
						vec4 unused_0_0[7];
						float _Downsample;
						vec4 unused_0_2;
					};
					layout(std140) uniform UnityPerCamera {
						vec4 unused_1_0[6];
						vec4 _ScreenParams;
						vec4 unused_1_2[2];
					};
					uniform  sampler2D _OcclusionTexture;
					in  vec2 vs_TEXCOORD1;
					layout(location = 0) out vec4 SV_Target0;
					layout(location = 1) out vec4 SV_Target1;
					vec4 u_xlat0;
					vec4 u_xlat1;
					vec4 u_xlat2;
					vec4 u_xlat3;
					vec4 u_xlat4;
					vec3 u_xlat5;
					vec3 u_xlat6;
					vec3 u_xlat7;
					vec3 u_xlat8;
					vec3 u_xlat9;
					float u_xlat10;
					float u_xlat11;
					float u_xlat15;
					float u_xlat16;
					void main()
					{
					    u_xlat0.xy = _ScreenParams.zw + vec2(-1.0, -1.0);
					    u_xlat0.xy = u_xlat0.xy / vec2(vec2(_Downsample, _Downsample));
					    u_xlat1.xy = (-u_xlat0.xy) + vs_TEXCOORD1.xy;
					    u_xlat1 = texture(_OcclusionTexture, u_xlat1.xy);
					    u_xlat6.xyz = u_xlat1.yzw * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					    u_xlat2 = texture(_OcclusionTexture, vs_TEXCOORD1.xy);
					    u_xlat7.xyz = u_xlat2.yzw * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					    u_xlat6.x = dot(u_xlat7.xyz, u_xlat6.xyz);
					    u_xlat6.x = u_xlat6.x + -0.800000012;
					    u_xlat6.x = u_xlat6.x * 5.00000048;
					    u_xlat6.x = clamp(u_xlat6.x, 0.0, 1.0);
					    u_xlat11 = u_xlat6.x * -2.0 + 3.0;
					    u_xlat6.x = u_xlat6.x * u_xlat6.x;
					    u_xlat6.x = u_xlat6.x * u_xlat11;
					    u_xlat1.x = u_xlat1.x * u_xlat6.x + u_xlat2.x;
					    u_xlat0.zw = (-u_xlat0.yx);
					    u_xlat3 = u_xlat0.xzwy + vs_TEXCOORD1.xyxy;
					    u_xlat0.xy = u_xlat0.xy + vs_TEXCOORD1.xy;
					    u_xlat0 = texture(_OcclusionTexture, u_xlat0.xy);
					    u_xlat4 = texture(_OcclusionTexture, u_xlat3.xy);
					    u_xlat3 = texture(_OcclusionTexture, u_xlat3.zw);
					    u_xlat9.xyz = u_xlat4.yzw * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					    u_xlat11 = dot(u_xlat7.xyz, u_xlat9.xyz);
					    u_xlat11 = u_xlat11 + -0.800000012;
					    u_xlat11 = u_xlat11 * 5.00000048;
					    u_xlat11 = clamp(u_xlat11, 0.0, 1.0);
					    u_xlat16 = u_xlat11 * -2.0 + 3.0;
					    u_xlat11 = u_xlat11 * u_xlat11;
					    u_xlat2.x = u_xlat11 * u_xlat16;
					    u_xlat6.x = u_xlat16 * u_xlat11 + u_xlat6.x;
					    u_xlat1.x = u_xlat4.x * u_xlat2.x + u_xlat1.x;
					    u_xlat8.xyz = u_xlat3.yzw * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					    u_xlat11 = dot(u_xlat7.xyz, u_xlat8.xyz);
					    u_xlat11 = u_xlat11 + -0.800000012;
					    u_xlat11 = u_xlat11 * 5.00000048;
					    u_xlat11 = clamp(u_xlat11, 0.0, 1.0);
					    u_xlat16 = u_xlat11 * -2.0 + 3.0;
					    u_xlat11 = u_xlat11 * u_xlat11;
					    u_xlat2.x = u_xlat11 * u_xlat16;
					    u_xlat6.x = u_xlat16 * u_xlat11 + u_xlat6.x;
					    u_xlat1.x = u_xlat3.x * u_xlat2.x + u_xlat1.x;
					    u_xlat5.xyz = u_xlat0.yzw * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					    u_xlat5.x = dot(u_xlat7.xyz, u_xlat5.xyz);
					    u_xlat5.x = u_xlat5.x + -0.800000012;
					    u_xlat5.x = u_xlat5.x * 5.00000048;
					    u_xlat5.x = clamp(u_xlat5.x, 0.0, 1.0);
					    u_xlat10 = u_xlat5.x * -2.0 + 3.0;
					    u_xlat5.x = u_xlat5.x * u_xlat5.x;
					    u_xlat15 = u_xlat5.x * u_xlat10;
					    u_xlat5.x = u_xlat10 * u_xlat5.x + u_xlat6.x;
					    u_xlat5.x = u_xlat5.x + 1.0;
					    u_xlat0.x = u_xlat0.x * u_xlat15 + u_xlat1.x;
					    u_xlat0.x = u_xlat0.x / u_xlat5.x;
					    SV_Target0.w = u_xlat0.x;
					    u_xlat0.x = (-u_xlat0.x) + 1.0;
					    u_xlat0.x = log2(u_xlat0.x);
					    u_xlat0.x = u_xlat0.x * 0.416666657;
					    u_xlat0.x = exp2(u_xlat0.x);
					    u_xlat0.x = u_xlat0.x * 1.05499995 + -0.0549999997;
					    u_xlat0.x = max(u_xlat0.x, 0.0);
					    SV_Target1.xyz = (-u_xlat0.xxx) + vec3(1.0, 1.0, 1.0);
					    SV_Target0.xyz = vec3(0.0, 0.0, 0.0);
					    SV_Target1.w = 0.0;
					    return;
					}"
				}
			}
		}
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 533013
			Program "vp" {
				SubProgram "d3d11 " {
					"vs_4_0
					
					#version 330
					#extension GL_ARB_explicit_attrib_location : require
					#extension GL_ARB_explicit_uniform_location : require
					
					#define HLSLCC_ENABLE_UNIFORM_BUFFERS 1
					#if HLSLCC_ENABLE_UNIFORM_BUFFERS
					#define UNITY_UNIFORM
					#else
					#define UNITY_UNIFORM uniform
					#endif
					#define UNITY_SUPPORTS_UNIFORM_LOCATION 1
					#if UNITY_SUPPORTS_UNIFORM_LOCATION
					#define UNITY_LOCATION(x) layout(location = x)
					#define UNITY_BINDING(x) layout(binding = x, std140)
					#else
					#define UNITY_LOCATION(x)
					#define UNITY_BINDING(x) layout(std140)
					#endif
					layout(std140) uniform VGlobals {
						vec4 unused_0_0[2];
						vec4 _MainTex_TexelSize;
						vec4 unused_0_2[6];
					};
					layout(std140) uniform UnityPerDraw {
						mat4x4 unity_ObjectToWorld;
						vec4 unused_1_1[6];
					};
					layout(std140) uniform UnityPerFrame {
						vec4 unused_2_0[17];
						mat4x4 unity_MatrixVP;
						vec4 unused_2_2[2];
					};
					in  vec4 in_POSITION0;
					in  vec4 in_TEXCOORD0;
					out vec2 vs_TEXCOORD0;
					 vec4 phase0_Output0_1;
					out vec2 vs_TEXCOORD1;
					out vec2 vs_TEXCOORD2;
					vec4 u_xlat0;
					bool u_xlatb0;
					vec4 u_xlat1;
					float u_xlat2;
					void main()
					{
					    u_xlat0 = in_POSITION0.yyyy * unity_ObjectToWorld[1];
					    u_xlat0 = unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    u_xlat0 = u_xlat0 + unity_ObjectToWorld[3];
					    u_xlat1 = u_xlat0.yyyy * unity_MatrixVP[1];
					    u_xlat1 = unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
					    u_xlat1 = unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
					    gl_Position = unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
					    u_xlatb0 = _MainTex_TexelSize.y<0.0;
					    u_xlat2 = (-in_TEXCOORD0.y) + 1.0;
					    u_xlat0.w = (u_xlatb0) ? u_xlat2 : in_TEXCOORD0.y;
					    u_xlat0.xyz = in_TEXCOORD0.xyx;
					    phase0_Output0_1 = u_xlat0;
					    vs_TEXCOORD2.xy = u_xlat0.zw;
					vs_TEXCOORD0 = phase0_Output0_1.xy;
					vs_TEXCOORD1 = phase0_Output0_1.zw;
					    return;
					}"
				}
			}
			Program "fp" {
				SubProgram "d3d11 " {
					"ps_4_0
					
					#version 330
					#extension GL_ARB_explicit_attrib_location : require
					#extension GL_ARB_explicit_uniform_location : require
					
					#define HLSLCC_ENABLE_UNIFORM_BUFFERS 1
					#if HLSLCC_ENABLE_UNIFORM_BUFFERS
					#define UNITY_UNIFORM
					#else
					#define UNITY_UNIFORM uniform
					#endif
					#define UNITY_SUPPORTS_UNIFORM_LOCATION 1
					#if UNITY_SUPPORTS_UNIFORM_LOCATION
					#define UNITY_LOCATION(x) layout(location = x)
					#define UNITY_BINDING(x) layout(binding = x, std140)
					#else
					#define UNITY_LOCATION(x)
					#define UNITY_BINDING(x) layout(std140)
					#endif
					layout(std140) uniform PGlobals {
						vec4 unused_0_0[2];
						vec4 _MainTex_TexelSize;
						vec4 unused_0_2[4];
						float _Downsample;
						vec4 unused_0_4;
					};
					uniform  sampler2D _OcclusionTexture;
					uniform  sampler2D _MainTex;
					in  vec2 vs_TEXCOORD2;
					layout(location = 0) out vec4 SV_Target0;
					vec4 u_xlat0;
					vec4 u_xlat1;
					vec4 u_xlat2;
					vec4 u_xlat3;
					vec4 u_xlat4;
					vec3 u_xlat5;
					vec3 u_xlat6;
					vec3 u_xlat7;
					vec3 u_xlat8;
					vec3 u_xlat9;
					float u_xlat10;
					float u_xlat11;
					float u_xlat15;
					float u_xlat16;
					void main()
					{
					    u_xlat0.xy = _MainTex_TexelSize.xy / vec2(vec2(_Downsample, _Downsample));
					    u_xlat1.xy = (-u_xlat0.xy) + vs_TEXCOORD2.xy;
					    u_xlat1 = texture(_OcclusionTexture, u_xlat1.xy);
					    u_xlat6.xyz = u_xlat1.yzw * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					    u_xlat2 = texture(_OcclusionTexture, vs_TEXCOORD2.xy);
					    u_xlat7.xyz = u_xlat2.yzw * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					    u_xlat6.x = dot(u_xlat7.xyz, u_xlat6.xyz);
					    u_xlat6.x = u_xlat6.x + -0.800000012;
					    u_xlat6.x = u_xlat6.x * 5.00000048;
					    u_xlat6.x = clamp(u_xlat6.x, 0.0, 1.0);
					    u_xlat11 = u_xlat6.x * -2.0 + 3.0;
					    u_xlat6.x = u_xlat6.x * u_xlat6.x;
					    u_xlat6.x = u_xlat6.x * u_xlat11;
					    u_xlat1.x = u_xlat1.x * u_xlat6.x + u_xlat2.x;
					    u_xlat0.zw = (-u_xlat0.yx);
					    u_xlat3 = u_xlat0.xzwy + vs_TEXCOORD2.xyxy;
					    u_xlat0.xy = u_xlat0.xy + vs_TEXCOORD2.xy;
					    u_xlat0 = texture(_OcclusionTexture, u_xlat0.xy);
					    u_xlat4 = texture(_OcclusionTexture, u_xlat3.xy);
					    u_xlat3 = texture(_OcclusionTexture, u_xlat3.zw);
					    u_xlat9.xyz = u_xlat4.yzw * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					    u_xlat11 = dot(u_xlat7.xyz, u_xlat9.xyz);
					    u_xlat11 = u_xlat11 + -0.800000012;
					    u_xlat11 = u_xlat11 * 5.00000048;
					    u_xlat11 = clamp(u_xlat11, 0.0, 1.0);
					    u_xlat16 = u_xlat11 * -2.0 + 3.0;
					    u_xlat11 = u_xlat11 * u_xlat11;
					    u_xlat2.x = u_xlat11 * u_xlat16;
					    u_xlat6.x = u_xlat16 * u_xlat11 + u_xlat6.x;
					    u_xlat1.x = u_xlat4.x * u_xlat2.x + u_xlat1.x;
					    u_xlat8.xyz = u_xlat3.yzw * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					    u_xlat11 = dot(u_xlat7.xyz, u_xlat8.xyz);
					    u_xlat11 = u_xlat11 + -0.800000012;
					    u_xlat11 = u_xlat11 * 5.00000048;
					    u_xlat11 = clamp(u_xlat11, 0.0, 1.0);
					    u_xlat16 = u_xlat11 * -2.0 + 3.0;
					    u_xlat11 = u_xlat11 * u_xlat11;
					    u_xlat2.x = u_xlat11 * u_xlat16;
					    u_xlat6.x = u_xlat16 * u_xlat11 + u_xlat6.x;
					    u_xlat1.x = u_xlat3.x * u_xlat2.x + u_xlat1.x;
					    u_xlat5.xyz = u_xlat0.yzw * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					    u_xlat5.x = dot(u_xlat7.xyz, u_xlat5.xyz);
					    u_xlat5.x = u_xlat5.x + -0.800000012;
					    u_xlat5.x = u_xlat5.x * 5.00000048;
					    u_xlat5.x = clamp(u_xlat5.x, 0.0, 1.0);
					    u_xlat10 = u_xlat5.x * -2.0 + 3.0;
					    u_xlat5.x = u_xlat5.x * u_xlat5.x;
					    u_xlat15 = u_xlat5.x * u_xlat10;
					    u_xlat5.x = u_xlat10 * u_xlat5.x + u_xlat6.x;
					    u_xlat5.x = u_xlat5.x + 1.0;
					    u_xlat0.x = u_xlat0.x * u_xlat15 + u_xlat1.x;
					    u_xlat0.x = u_xlat0.x / u_xlat5.x;
					    u_xlat0.x = (-u_xlat0.x) + 1.0;
					    u_xlat0.x = log2(u_xlat0.x);
					    u_xlat0.x = u_xlat0.x * 0.416666657;
					    u_xlat0.x = exp2(u_xlat0.x);
					    u_xlat0.x = u_xlat0.x * 1.05499995 + -0.0549999997;
					    u_xlat0.x = max(u_xlat0.x, 0.0);
					    u_xlat0.x = (-u_xlat0.x) + 1.0;
					    SV_Target0.xyz = (-u_xlat0.xxx) + vec3(1.0, 1.0, 1.0);
					    u_xlat0 = texture(_MainTex, vs_TEXCOORD2.xy);
					    SV_Target0.w = u_xlat0.w;
					    return;
					}"
				}
			}
		}
	}
}