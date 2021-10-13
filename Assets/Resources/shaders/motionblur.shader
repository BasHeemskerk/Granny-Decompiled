Shader "Hidden/Post FX/Motion Blur" {
	Properties {
	}
	SubShader {
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 42792
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
						vec4 unused_0_0[3];
						vec4 _MainTex_ST;
						vec4 unused_0_2[5];
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
					out vec2 vs_TEXCOORD1;
					vec4 u_xlat0;
					vec4 u_xlat1;
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
					    vs_TEXCOORD1.xy = in_TEXCOORD0.xy * _MainTex_ST.xy + _MainTex_ST.zw;
					    vs_TEXCOORD0.xy = in_TEXCOORD0.xy;
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
						vec4 unused_0_0[4];
						vec4 _CameraMotionVectorsTexture_TexelSize;
						vec4 unused_0_2;
						float _VelocityScale;
						vec4 unused_0_4;
						float _RcpMaxBlurRadius;
						vec4 unused_0_6;
					};
					layout(std140) uniform UnityPerCamera {
						vec4 unused_1_0[7];
						vec4 _ZBufferParams;
						vec4 unity_OrthoParams;
					};
					uniform  sampler2D _CameraMotionVectorsTexture;
					uniform  sampler2D _CameraDepthTexture;
					in  vec2 vs_TEXCOORD0;
					layout(location = 0) out vec4 SV_Target0;
					vec2 u_xlat0;
					vec4 u_xlat1;
					float u_xlat2;
					float u_xlat4;
					void main()
					{
					    u_xlat0.x = _VelocityScale * 0.5;
					    u_xlat0.xy = u_xlat0.xx * _CameraMotionVectorsTexture_TexelSize.zw;
					    u_xlat1 = texture(_CameraMotionVectorsTexture, vs_TEXCOORD0.xy);
					    u_xlat0.xy = u_xlat0.xy * u_xlat1.xy;
					    u_xlat4 = dot(u_xlat0.xy, u_xlat0.xy);
					    u_xlat4 = sqrt(u_xlat4);
					    u_xlat4 = u_xlat4 * unused_0_4.y;
					    u_xlat4 = max(u_xlat4, 1.0);
					    u_xlat0.xy = u_xlat0.xy / vec2(u_xlat4);
					    u_xlat0.xy = u_xlat0.xy * unused_0_4.yy + vec2(1.0, 1.0);
					    SV_Target0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    u_xlat0.x = (-unity_OrthoParams.w) + 1.0;
					    u_xlat1 = texture(_CameraDepthTexture, vs_TEXCOORD0.xy);
					    u_xlat2 = u_xlat1.x * _ZBufferParams.x;
					    u_xlat0.x = u_xlat0.x * u_xlat2 + _ZBufferParams.y;
					    u_xlat2 = (-unity_OrthoParams.w) * u_xlat2 + 1.0;
					    SV_Target0.z = u_xlat2 / u_xlat0.x;
					    SV_Target0.w = 0.0;
					    return;
					}"
				}
			}
		}
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 71108
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
						vec4 unused_0_0[3];
						vec4 _MainTex_ST;
						vec4 unused_0_2[5];
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
					out vec2 vs_TEXCOORD1;
					vec4 u_xlat0;
					vec4 u_xlat1;
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
					    vs_TEXCOORD1.xy = in_TEXCOORD0.xy * _MainTex_ST.xy + _MainTex_ST.zw;
					    vs_TEXCOORD0.xy = in_TEXCOORD0.xy;
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
						float _MaxBlurRadius;
						vec4 unused_0_4;
					};
					uniform  sampler2D _MainTex;
					in  vec2 vs_TEXCOORD0;
					layout(location = 0) out vec4 SV_Target0;
					vec4 u_xlat0;
					vec4 u_xlat1;
					bool u_xlatb1;
					vec4 u_xlat2;
					float u_xlat4;
					float u_xlat6;
					bool u_xlatb6;
					float u_xlat9;
					void main()
					{
					    u_xlat0 = _MainTex_TexelSize.xyxy * vec4(-0.5, -0.5, 0.5, -0.5) + vs_TEXCOORD0.xyxy;
					    u_xlat1 = texture(_MainTex, u_xlat0.xy);
					    u_xlat0 = texture(_MainTex, u_xlat0.zw);
					    u_xlat0.xy = u_xlat0.xy * vec2(2.0, 2.0) + vec2(-1.0, -1.0);
					    u_xlat0.zw = u_xlat1.xy * vec2(2.0, 2.0) + vec2(-1.0, -1.0);
					    u_xlat0 = u_xlat0 * vec4(_MaxBlurRadius);
					    u_xlat1.x = dot(u_xlat0.zw, u_xlat0.zw);
					    u_xlat4 = dot(u_xlat0.xy, u_xlat0.xy);
					    u_xlatb1 = u_xlat1.x<u_xlat4;
					    u_xlat0.xy = (bool(u_xlatb1)) ? u_xlat0.xy : u_xlat0.zw;
					    u_xlat6 = dot(u_xlat0.xy, u_xlat0.xy);
					    u_xlat1 = _MainTex_TexelSize.xyxy * vec4(-0.5, 0.5, 0.5, 0.5) + vs_TEXCOORD0.xyxy;
					    u_xlat2 = texture(_MainTex, u_xlat1.xy);
					    u_xlat1 = texture(_MainTex, u_xlat1.zw);
					    u_xlat1.xy = u_xlat1.xy * vec2(2.0, 2.0) + vec2(-1.0, -1.0);
					    u_xlat1.zw = u_xlat2.xy * vec2(2.0, 2.0) + vec2(-1.0, -1.0);
					    u_xlat1 = u_xlat1 * vec4(_MaxBlurRadius);
					    u_xlat9 = dot(u_xlat1.zw, u_xlat1.zw);
					    u_xlatb6 = u_xlat6<u_xlat9;
					    u_xlat0.xy = (bool(u_xlatb6)) ? u_xlat1.zw : u_xlat0.xy;
					    u_xlat6 = dot(u_xlat0.xy, u_xlat0.xy);
					    u_xlat9 = dot(u_xlat1.xy, u_xlat1.xy);
					    u_xlatb6 = u_xlat6<u_xlat9;
					    SV_Target0.xy = (bool(u_xlatb6)) ? u_xlat1.xy : u_xlat0.xy;
					    SV_Target0.zw = vec2(0.0, 0.0);
					    return;
					}"
				}
			}
		}
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 175366
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
						vec4 unused_0_0[3];
						vec4 _MainTex_ST;
						vec4 unused_0_2[5];
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
					out vec2 vs_TEXCOORD1;
					vec4 u_xlat0;
					vec4 u_xlat1;
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
					    vs_TEXCOORD1.xy = in_TEXCOORD0.xy * _MainTex_ST.xy + _MainTex_ST.zw;
					    vs_TEXCOORD0.xy = in_TEXCOORD0.xy;
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
					in  vec2 vs_TEXCOORD0;
					layout(location = 0) out vec4 SV_Target0;
					vec4 u_xlat0;
					vec4 u_xlat1;
					vec4 u_xlat2;
					float u_xlat6;
					bool u_xlatb6;
					float u_xlat9;
					void main()
					{
					    u_xlat0 = _MainTex_TexelSize.xyxy * vec4(-0.5, -0.5, 0.5, -0.5) + vs_TEXCOORD0.xyxy;
					    u_xlat1 = texture(_MainTex, u_xlat0.xy);
					    u_xlat0 = texture(_MainTex, u_xlat0.zw);
					    u_xlat6 = dot(u_xlat1.xy, u_xlat1.xy);
					    u_xlat9 = dot(u_xlat0.xy, u_xlat0.xy);
					    u_xlatb6 = u_xlat6<u_xlat9;
					    u_xlat0.xy = (bool(u_xlatb6)) ? u_xlat0.xy : u_xlat1.xy;
					    u_xlat6 = dot(u_xlat0.xy, u_xlat0.xy);
					    u_xlat1 = _MainTex_TexelSize.xyxy * vec4(-0.5, 0.5, 0.5, 0.5) + vs_TEXCOORD0.xyxy;
					    u_xlat2 = texture(_MainTex, u_xlat1.xy);
					    u_xlat1 = texture(_MainTex, u_xlat1.zw);
					    u_xlat9 = dot(u_xlat2.xy, u_xlat2.xy);
					    u_xlatb6 = u_xlat6<u_xlat9;
					    u_xlat0.xy = (bool(u_xlatb6)) ? u_xlat2.xy : u_xlat0.xy;
					    u_xlat6 = dot(u_xlat0.xy, u_xlat0.xy);
					    u_xlat9 = dot(u_xlat1.xy, u_xlat1.xy);
					    u_xlatb6 = u_xlat6<u_xlat9;
					    SV_Target0.xy = (bool(u_xlatb6)) ? u_xlat1.xy : u_xlat0.xy;
					    SV_Target0.zw = vec2(0.0, 0.0);
					    return;
					}"
				}
			}
		}
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 233458
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
						vec4 unused_0_0[3];
						vec4 _MainTex_ST;
						vec4 unused_0_2[5];
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
					out vec2 vs_TEXCOORD1;
					vec4 u_xlat0;
					vec4 u_xlat1;
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
					    vs_TEXCOORD1.xy = in_TEXCOORD0.xy * _MainTex_ST.xy + _MainTex_ST.zw;
					    vs_TEXCOORD0.xy = in_TEXCOORD0.xy;
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
						vec4 unused_0_2[3];
						int _TileMaxLoop;
						vec2 _TileMaxOffs;
						vec4 unused_0_5[2];
					};
					uniform  sampler2D _MainTex;
					in  vec2 vs_TEXCOORD0;
					layout(location = 0) out vec4 SV_Target0;
					vec2 u_xlat0;
					vec4 u_xlat1;
					int u_xlati2;
					vec2 u_xlat3;
					vec4 u_xlat4;
					vec2 u_xlat7;
					bool u_xlatb7;
					vec2 u_xlat10;
					vec2 u_xlat13;
					bool u_xlatb13;
					int u_xlati17;
					float u_xlat18;
					void main()
					{
					    u_xlat0.xy = _MainTex_TexelSize.xy * vec2(_TileMaxOffs.x, _TileMaxOffs.y) + vs_TEXCOORD0.xy;
					    u_xlat1.y = float(0.0);
					    u_xlat1.z = float(0.0);
					    u_xlat1.xw = _MainTex_TexelSize.xy;
					    u_xlat10.x = float(0.0);
					    u_xlat10.y = float(0.0);
					    for(int u_xlati_loop_1 = 0 ; u_xlati_loop_1<_TileMaxLoop ; u_xlati_loop_1++)
					    {
					        u_xlat7.x = float(u_xlati_loop_1);
					        u_xlat7.xy = u_xlat1.xy * u_xlat7.xx + u_xlat0.xy;
					        u_xlat3.xy = u_xlat10.xy;
					        for(int u_xlati_loop_2 = 0 ; u_xlati_loop_2<_TileMaxLoop ; u_xlati_loop_2++)
					        {
					            u_xlat13.x = float(u_xlati_loop_2);
					            u_xlat13.xy = u_xlat1.zw * u_xlat13.xx + u_xlat7.xy;
					            u_xlat4 = texture(_MainTex, u_xlat13.xy);
					            u_xlat13.x = dot(u_xlat3.xy, u_xlat3.xy);
					            u_xlat18 = dot(u_xlat4.xy, u_xlat4.xy);
					            u_xlatb13 = u_xlat13.x<u_xlat18;
					            u_xlat3.xy = (bool(u_xlatb13)) ? u_xlat4.xy : u_xlat3.xy;
					        }
					        u_xlat10.xy = u_xlat3.xy;
					    }
					    SV_Target0.xy = u_xlat10.xy;
					    SV_Target0.zw = vec2(0.0, 0.0);
					    return;
					}"
				}
			}
		}
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 317650
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
						vec4 unused_0_0[3];
						vec4 _MainTex_ST;
						vec4 unused_0_2[5];
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
					out vec2 vs_TEXCOORD1;
					vec4 u_xlat0;
					vec4 u_xlat1;
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
					    vs_TEXCOORD1.xy = in_TEXCOORD0.xy * _MainTex_ST.xy + _MainTex_ST.zw;
					    vs_TEXCOORD0.xy = in_TEXCOORD0.xy;
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
					in  vec2 vs_TEXCOORD0;
					layout(location = 0) out vec4 SV_Target0;
					vec4 u_xlat0;
					vec4 u_xlat1;
					vec4 u_xlat2;
					vec4 u_xlat3;
					float u_xlat8;
					bool u_xlatb8;
					vec2 u_xlat9;
					float u_xlat12;
					bool u_xlatb12;
					void main()
					{
					    u_xlat0 = _MainTex_TexelSize.yyxy * vec4(0.0, 1.0, 1.0, 1.0) + vs_TEXCOORD0.xyxy;
					    u_xlat1 = texture(_MainTex, u_xlat0.xy);
					    u_xlat0 = texture(_MainTex, u_xlat0.zw);
					    u_xlat8 = dot(u_xlat1.xy, u_xlat1.xy);
					    u_xlat12 = dot(u_xlat0.xy, u_xlat0.xy);
					    u_xlatb8 = u_xlat8<u_xlat12;
					    u_xlat0.xy = (bool(u_xlatb8)) ? u_xlat0.xy : u_xlat1.xy;
					    u_xlat8 = dot(u_xlat0.xy, u_xlat0.xy);
					    u_xlat1 = _MainTex_TexelSize.xyxy * vec4(1.0, 0.0, -1.0, 1.0) + vs_TEXCOORD0.xyxy;
					    u_xlat2 = texture(_MainTex, u_xlat1.zw);
					    u_xlat1 = texture(_MainTex, u_xlat1.xy);
					    u_xlat12 = dot(u_xlat2.xy, u_xlat2.xy);
					    u_xlatb8 = u_xlat12<u_xlat8;
					    u_xlat0.xy = (bool(u_xlatb8)) ? u_xlat0.xy : u_xlat2.xy;
					    u_xlat8 = dot(u_xlat0.xy, u_xlat0.xy);
					    u_xlat12 = dot(u_xlat1.xy, u_xlat1.xy);
					    u_xlat2 = texture(_MainTex, vs_TEXCOORD0.xy);
					    u_xlat9.xy = u_xlat2.xy * vec2(1.00999999, 1.00999999);
					    u_xlat2.x = dot(u_xlat9.xy, u_xlat9.xy);
					    u_xlatb12 = u_xlat2.x<u_xlat12;
					    u_xlat1.xy = (bool(u_xlatb12)) ? u_xlat1.xy : u_xlat9.xy;
					    u_xlat12 = dot(u_xlat1.xy, u_xlat1.xy);
					    u_xlat2 = (-_MainTex_TexelSize.xyxy) * vec4(-1.0, 1.0, 1.0, 0.0) + vs_TEXCOORD0.xyxy;
					    u_xlat3 = texture(_MainTex, u_xlat2.zw);
					    u_xlat2 = texture(_MainTex, u_xlat2.xy);
					    u_xlat9.x = dot(u_xlat3.xy, u_xlat3.xy);
					    u_xlatb12 = u_xlat9.x<u_xlat12;
					    u_xlat1.xy = (bool(u_xlatb12)) ? u_xlat1.xy : u_xlat3.xy;
					    u_xlat12 = dot(u_xlat1.xy, u_xlat1.xy);
					    u_xlatb8 = u_xlat12<u_xlat8;
					    u_xlat0.xy = (bool(u_xlatb8)) ? u_xlat0.xy : u_xlat1.xy;
					    u_xlat8 = dot(u_xlat0.xy, u_xlat0.xy);
					    u_xlat12 = dot(u_xlat2.xy, u_xlat2.xy);
					    u_xlat1 = (-_MainTex_TexelSize.xyyy) * vec4(1.0, 1.0, 0.0, 1.0) + vs_TEXCOORD0.xyxy;
					    u_xlat3 = texture(_MainTex, u_xlat1.zw);
					    u_xlat1 = texture(_MainTex, u_xlat1.xy);
					    u_xlat9.x = dot(u_xlat3.xy, u_xlat3.xy);
					    u_xlatb12 = u_xlat9.x<u_xlat12;
					    u_xlat9.xy = (bool(u_xlatb12)) ? u_xlat2.xy : u_xlat3.xy;
					    u_xlat12 = dot(u_xlat9.xy, u_xlat9.xy);
					    u_xlat2.x = dot(u_xlat1.xy, u_xlat1.xy);
					    u_xlatb12 = u_xlat2.x<u_xlat12;
					    u_xlat1.xy = (bool(u_xlatb12)) ? u_xlat9.xy : u_xlat1.xy;
					    u_xlat12 = dot(u_xlat1.xy, u_xlat1.xy);
					    u_xlatb8 = u_xlat12<u_xlat8;
					    u_xlat0.xy = (bool(u_xlatb8)) ? u_xlat0.xy : u_xlat1.xy;
					    SV_Target0.xy = u_xlat0.xy * vec2(0.990099013, 0.990099013);
					    SV_Target0.zw = vec2(0.0, 0.0);
					    return;
					}"
				}
			}
		}
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 336874
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
					    phase0_Output0_1.w = (u_xlatb0) ? u_xlat2 : in_TEXCOORD0.y;
					    phase0_Output0_1.xyz = in_TEXCOORD0.xyx;
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
						vec4 unused_0_2[2];
						vec2 _VelocityTex_TexelSize;
						vec2 _NeighborMaxTex_TexelSize;
						vec4 unused_0_5;
						float _MaxBlurRadius;
						float _LoopCount;
						vec4 unused_0_8;
					};
					layout(std140) uniform UnityPerCamera {
						vec4 unused_1_0[6];
						vec4 _ScreenParams;
						vec4 unused_1_2[2];
					};
					uniform  sampler2D _MainTex;
					uniform  sampler2D _VelocityTex;
					uniform  sampler2D _NeighborMaxTex;
					in  vec2 vs_TEXCOORD0;
					in  vec2 vs_TEXCOORD1;
					layout(location = 0) out vec4 SV_Target0;
					vec4 u_xlat0;
					vec4 u_xlat1;
					vec4 u_xlat2;
					vec3 u_xlat3;
					float u_xlat4;
					vec4 u_xlat5;
					vec4 u_xlat6;
					vec3 u_xlat7;
					bvec2 u_xlatb7;
					vec4 u_xlat8;
					vec4 u_xlat9;
					float u_xlat14;
					float u_xlat21;
					vec2 u_xlat23;
					float u_xlat24;
					float u_xlat27;
					float u_xlat31;
					bool u_xlatb31;
					float u_xlat32;
					bool u_xlatb32;
					float u_xlat34;
					float u_xlat37;
					float u_xlat38;
					void main()
					{
					    u_xlat0 = texture(_MainTex, vs_TEXCOORD0.xy);
					    u_xlat1.xy = vs_TEXCOORD1.xy + vec2(2.0, 0.0);
					    u_xlat1.xy = u_xlat1.xy * _ScreenParams.xy;
					    u_xlat1.xy = floor(u_xlat1.xy);
					    u_xlat1.x = dot(vec2(0.0671105608, 0.00583714992), u_xlat1.xy);
					    u_xlat1.x = fract(u_xlat1.x);
					    u_xlat1.x = u_xlat1.x * 52.9829178;
					    u_xlat1.x = fract(u_xlat1.x);
					    u_xlat1.x = u_xlat1.x * 6.28318548;
					    u_xlat2.x = cos(u_xlat1.x);
					    u_xlat1.x = sin(u_xlat1.x);
					    u_xlat2.y = u_xlat1.x;
					    u_xlat1.xy = u_xlat2.xy * vec2(_NeighborMaxTex_TexelSize.x, _NeighborMaxTex_TexelSize.y);
					    u_xlat1.xy = u_xlat1.xy * vec2(0.25, 0.25) + vs_TEXCOORD1.xy;
					    u_xlat1 = texture(_NeighborMaxTex, u_xlat1.xy);
					    u_xlat21 = dot(u_xlat1.xy, u_xlat1.xy);
					    u_xlat21 = sqrt(u_xlat21);
					    u_xlatb31 = u_xlat21<2.0;
					    if(u_xlatb31){
					        SV_Target0 = u_xlat0;
					        return;
					    }
					    u_xlat2 = textureLod(_VelocityTex, vs_TEXCOORD1.xy, 0.0);
					    u_xlat2.xy = u_xlat2.xy * vec2(2.0, 2.0) + vec2(-1.0, -1.0);
					    u_xlat2.xy = u_xlat2.xy * vec2(_MaxBlurRadius);
					    u_xlat31 = dot(u_xlat2.xy, u_xlat2.xy);
					    u_xlat31 = sqrt(u_xlat31);
					    u_xlat3.xy = max(vec2(u_xlat31), vec2(0.5, 1.0));
					    u_xlat31 = float(1.0) / u_xlat2.z;
					    u_xlat32 = u_xlat3.x + u_xlat3.x;
					    u_xlatb32 = u_xlat21<u_xlat32;
					    u_xlat3.x = u_xlat21 / u_xlat3.x;
					    u_xlat2.xy = u_xlat2.xy * u_xlat3.xx;
					    u_xlat2.xy = (bool(u_xlatb32)) ? u_xlat2.xy : u_xlat1.xy;
					    u_xlat32 = u_xlat21 * 0.5;
					    u_xlat32 = min(u_xlat32, _LoopCount);
					    u_xlat32 = floor(u_xlat32);
					    u_xlat3.x = float(1.0) / u_xlat32;
					    u_xlat23.xy = vs_TEXCOORD0.xy * _ScreenParams.xy;
					    u_xlat23.xy = floor(u_xlat23.xy);
					    u_xlat23.x = dot(vec2(0.0671105608, 0.00583714992), u_xlat23.xy);
					    u_xlat3.z = fract(u_xlat23.x);
					    u_xlat23.xy = u_xlat3.zx * vec2(52.9829178, 0.25);
					    u_xlat23.x = fract(u_xlat23.x);
					    u_xlat23.x = u_xlat23.x + -0.5;
					    u_xlat4 = (-u_xlat3.x) * 0.5 + 1.0;
					    u_xlat5.w = 1.0;
					    u_xlat6.x = float(0.0);
					    u_xlat6.y = float(0.0);
					    u_xlat6.z = float(0.0);
					    u_xlat6.w = float(0.0);
					    u_xlat14 = u_xlat4;
					    u_xlat24 = 0.0;
					    u_xlat34 = u_xlat3.y;
					    while(true){
					        u_xlatb7.x = u_xlat23.y>=u_xlat14;
					        if(u_xlatb7.x){break;}
					        u_xlat7.xy = vec2(u_xlat24) * vec2(0.25, 0.5);
					        u_xlat7.xy = fract(u_xlat7.xy);
					        u_xlatb7.xy = lessThan(vec4(0.499000013, 0.499000013, 0.0, 0.0), u_xlat7.xyxx).xy;
					        u_xlat7.xz = (u_xlatb7.x) ? u_xlat2.xy : u_xlat1.xy;
					        u_xlat37 = (u_xlatb7.y) ? (-u_xlat14) : u_xlat14;
					        u_xlat37 = u_xlat23.x * u_xlat3.x + u_xlat37;
					        u_xlat7.xz = vec2(u_xlat37) * u_xlat7.xz;
					        u_xlat8.xy = u_xlat7.xz * _MainTex_TexelSize.xy + vs_TEXCOORD0.xy;
					        u_xlat7.xz = u_xlat7.xz * _VelocityTex_TexelSize.xy + vs_TEXCOORD1.xy;
					        u_xlat8 = textureLod(_MainTex, u_xlat8.xy, 0.0);
					        u_xlat9 = textureLod(_VelocityTex, u_xlat7.xz, 0.0);
					        u_xlat7.xz = u_xlat9.xy * vec2(2.0, 2.0) + vec2(-1.0, -1.0);
					        u_xlat7.xz = u_xlat7.xz * vec2(_MaxBlurRadius);
					        u_xlat38 = u_xlat2.z + (-u_xlat9.z);
					        u_xlat38 = u_xlat31 * u_xlat38;
					        u_xlat38 = u_xlat38 * 20.0;
					        u_xlat38 = clamp(u_xlat38, 0.0, 1.0);
					        u_xlat7.x = dot(u_xlat7.xz, u_xlat7.xz);
					        u_xlat7.x = sqrt(u_xlat7.x);
					        u_xlat7.x = (-u_xlat34) + u_xlat7.x;
					        u_xlat7.x = u_xlat38 * u_xlat7.x + u_xlat34;
					        u_xlat27 = (-u_xlat21) * abs(u_xlat37) + u_xlat7.x;
					        u_xlat27 = clamp(u_xlat27, 0.0, 1.0);
					        u_xlat27 = u_xlat27 / u_xlat7.x;
					        u_xlat37 = (-u_xlat14) + 1.20000005;
					        u_xlat27 = u_xlat37 * u_xlat27;
					        u_xlat5.xyz = u_xlat8.xyz;
					        u_xlat6 = u_xlat5 * vec4(u_xlat27) + u_xlat6;
					        u_xlat34 = max(u_xlat34, u_xlat7.x);
					        u_xlat5.x = (-u_xlat3.x) + u_xlat14;
					        u_xlat14 = (u_xlatb7.y) ? u_xlat5.x : u_xlat14;
					        u_xlat24 = u_xlat24 + 1.0;
					    }
					    u_xlat1.x = dot(vec2(u_xlat34), vec2(u_xlat32));
					    u_xlat1.x = 1.20000005 / u_xlat1.x;
					    u_xlat2.xyz = u_xlat0.xyz;
					    u_xlat2.w = 1.0;
					    u_xlat1 = u_xlat2 * u_xlat1.xxxx + u_xlat6;
					    SV_Target0.xyz = u_xlat1.xyz / u_xlat1.www;
					    SV_Target0.w = u_xlat0.w;
					    return;
					}"
				}
			}
		}
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 434452
			Program "vp" {
				SubProgram "d3d11 " {
					"vs_4_0
					
					#version 330
					#extension GL_ARB_explicit_attrib_location : require
					#extension GL_ARB_explicit_uniform_location : require
					
					in  vec4 in_POSITION0;
					in  vec4 in_TEXCOORD0;
					out vec2 vs_TEXCOORD0;
					out vec2 vs_TEXCOORD1;
					void main()
					{
					    gl_Position = in_POSITION0;
					    vs_TEXCOORD0.xy = in_TEXCOORD0.xy * vec2(1.0, -1.0) + vec2(0.0, 1.0);
					    vs_TEXCOORD1.xy = vec2(0.0, 0.0);
					    return;
					}"
				}
				SubProgram "d3d11 " {
					Keywords { "UNITY_COLORSPACE_GAMMA" }
					"vs_4_0
					
					#version 330
					#extension GL_ARB_explicit_attrib_location : require
					#extension GL_ARB_explicit_uniform_location : require
					
					in  vec4 in_POSITION0;
					in  vec4 in_TEXCOORD0;
					out vec2 vs_TEXCOORD0;
					out vec2 vs_TEXCOORD1;
					void main()
					{
					    gl_Position = in_POSITION0;
					    vs_TEXCOORD0.xy = in_TEXCOORD0.xy * vec2(1.0, -1.0) + vec2(0.0, 1.0);
					    vs_TEXCOORD1.xy = vec2(0.0, 0.0);
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
					layout(std140) uniform UnityPerCamera {
						vec4 unused_0_0[6];
						vec4 _ScreenParams;
						vec4 unused_0_2[2];
					};
					uniform  sampler2D _MainTex;
					in  vec2 vs_TEXCOORD0;
					layout(location = 0) out vec4 SV_Target0;
					layout(location = 1) out vec4 SV_Target1;
					vec4 u_xlat0;
					bool u_xlatb0;
					vec4 u_xlat1;
					float u_xlat2;
					void main()
					{
					    u_xlat0 = texture(_MainTex, vs_TEXCOORD0.xy);
					    SV_Target0 = vec4(dot(vec3(0.298999995, 0.587000012, 0.114), u_xlat0.xyz));
					    u_xlat0.x = vs_TEXCOORD0.x * _ScreenParams.x;
					    u_xlat0.x = u_xlat0.x * 0.5;
					    u_xlat2 = floor(u_xlat0.x);
					    u_xlat0.x = fract(u_xlat0.x);
					    u_xlatb0 = 0.5<u_xlat0.x;
					    u_xlat0.xzw = (bool(u_xlatb0)) ? vec3(0.5, -0.418687999, -0.0813120008) : vec3(-0.168735996, -0.331263989, 0.5);
					    u_xlat2 = u_xlat2 * 2.0 + 1.0;
					    u_xlat1.x = _ScreenParams.z + -1.0;
					    u_xlat1.x = u_xlat2 * u_xlat1.x;
					    u_xlat1.y = vs_TEXCOORD0.y;
					    u_xlat1 = texture(_MainTex, u_xlat1.xy);
					    u_xlat0.x = dot(u_xlat0.xzw, u_xlat1.xyz);
					    SV_Target1 = u_xlat0.xxxx + vec4(0.5, 0.5, 0.5, 0.5);
					    return;
					}"
				}
				SubProgram "d3d11 " {
					Keywords { "UNITY_COLORSPACE_GAMMA" }
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
					layout(std140) uniform UnityPerCamera {
						vec4 unused_0_0[6];
						vec4 _ScreenParams;
						vec4 unused_0_2[2];
					};
					uniform  sampler2D _MainTex;
					in  vec2 vs_TEXCOORD0;
					layout(location = 0) out vec4 SV_Target0;
					layout(location = 1) out vec4 SV_Target1;
					vec4 u_xlat0;
					bool u_xlatb0;
					vec4 u_xlat1;
					float u_xlat2;
					void main()
					{
					    u_xlat0 = texture(_MainTex, vs_TEXCOORD0.xy);
					    SV_Target0 = vec4(dot(vec3(0.298999995, 0.587000012, 0.114), u_xlat0.xyz));
					    u_xlat0.x = vs_TEXCOORD0.x * _ScreenParams.x;
					    u_xlat0.x = u_xlat0.x * 0.5;
					    u_xlat2 = floor(u_xlat0.x);
					    u_xlat0.x = fract(u_xlat0.x);
					    u_xlatb0 = 0.5<u_xlat0.x;
					    u_xlat0.xzw = (bool(u_xlatb0)) ? vec3(0.5, -0.418687999, -0.0813120008) : vec3(-0.168735996, -0.331263989, 0.5);
					    u_xlat2 = u_xlat2 * 2.0 + 1.0;
					    u_xlat1.x = _ScreenParams.z + -1.0;
					    u_xlat1.x = u_xlat2 * u_xlat1.x;
					    u_xlat1.y = vs_TEXCOORD0.y;
					    u_xlat1 = texture(_MainTex, u_xlat1.xy);
					    u_xlat0.x = dot(u_xlat0.xzw, u_xlat1.xyz);
					    SV_Target1 = u_xlat0.xxxx + vec4(0.5, 0.5, 0.5, 0.5);
					    return;
					}"
				}
			}
		}
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 509180
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
					    phase0_Output0_1.w = (u_xlatb0) ? u_xlat2 : in_TEXCOORD0.y;
					    phase0_Output0_1.xyz = in_TEXCOORD0.xyx;
					vs_TEXCOORD0 = phase0_Output0_1.xy;
					vs_TEXCOORD1 = phase0_Output0_1.zw;
					    return;
					}"
				}
				SubProgram "d3d11 " {
					Keywords { "UNITY_COLORSPACE_GAMMA" }
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
					    phase0_Output0_1.w = (u_xlatb0) ? u_xlat2 : in_TEXCOORD0.y;
					    phase0_Output0_1.xyz = in_TEXCOORD0.xyx;
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
						float _History1Weight;
						float _History2Weight;
						float _History3Weight;
						float _History4Weight;
					};
					uniform  sampler2D _MainTex;
					uniform  sampler2D _History1LumaTex;
					uniform  sampler2D _History1ChromaTex;
					uniform  sampler2D _History2LumaTex;
					uniform  sampler2D _History2ChromaTex;
					uniform  sampler2D _History3LumaTex;
					uniform  sampler2D _History3ChromaTex;
					uniform  sampler2D _History4LumaTex;
					uniform  sampler2D _History4ChromaTex;
					in  vec2 vs_TEXCOORD0;
					in  vec2 vs_TEXCOORD1;
					layout(location = 0) out vec4 SV_Target0;
					vec4 u_xlat0;
					vec4 u_xlat1;
					vec4 u_xlat2;
					vec4 u_xlat3;
					vec4 u_xlat4;
					float u_xlat5;
					float u_xlat15;
					void main()
					{
					    u_xlat0 = texture(_History1LumaTex, vs_TEXCOORD1.xy);
					    u_xlat5 = vs_TEXCOORD1.x * _MainTex_TexelSize.z;
					    u_xlat5 = u_xlat5 * 0.5;
					    u_xlat5 = floor(u_xlat5);
					    u_xlat5 = u_xlat5 * 2.0 + 0.5;
					    u_xlat1.z = u_xlat5 * _MainTex_TexelSize.x + _MainTex_TexelSize.x;
					    u_xlat1.x = u_xlat5 * _MainTex_TexelSize.x;
					    u_xlat1.yw = vs_TEXCOORD1.yy;
					    u_xlat2 = texture(_History1ChromaTex, u_xlat1.zw);
					    u_xlat5 = u_xlat2.x + -0.5;
					    u_xlat2.xy = vec2(u_xlat5) * vec2(1.40199995, 0.714139998);
					    u_xlat3 = texture(_History1ChromaTex, u_xlat1.xy);
					    u_xlat5 = u_xlat3.x + -0.5;
					    u_xlat2.z = u_xlat5 * -0.344139993 + (-u_xlat2.y);
					    u_xlat2.w = u_xlat5 * 1.77199996;
					    u_xlat0.xyz = u_xlat0.xxx + u_xlat2.xzw;
					    u_xlat2 = texture(_MainTex, vs_TEXCOORD0.xy);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(vec3(_History1Weight, _History1Weight, _History1Weight)) + u_xlat2.xyz;
					    SV_Target0.w = u_xlat2.w;
					    u_xlat2 = texture(_History2LumaTex, vs_TEXCOORD1.xy);
					    u_xlat3 = texture(_History2ChromaTex, u_xlat1.zw);
					    u_xlat15 = u_xlat3.x + -0.5;
					    u_xlat3.xy = vec2(u_xlat15) * vec2(1.40199995, 0.714139998);
					    u_xlat4 = texture(_History2ChromaTex, u_xlat1.xy);
					    u_xlat15 = u_xlat4.x + -0.5;
					    u_xlat3.z = u_xlat15 * -0.344139993 + (-u_xlat3.y);
					    u_xlat3.w = u_xlat15 * 1.77199996;
					    u_xlat2.xyz = u_xlat2.xxx + u_xlat3.xzw;
					    u_xlat0.xyz = u_xlat2.xyz * vec3(_History2Weight) + u_xlat0.xyz;
					    u_xlat2 = texture(_History3ChromaTex, u_xlat1.zw);
					    u_xlat3 = texture(_History4ChromaTex, u_xlat1.zw);
					    u_xlat15 = u_xlat3.x + -0.5;
					    u_xlat3.xy = vec2(u_xlat15) * vec2(1.40199995, 0.714139998);
					    u_xlat15 = u_xlat2.x + -0.5;
					    u_xlat2.xy = vec2(u_xlat15) * vec2(1.40199995, 0.714139998);
					    u_xlat4 = texture(_History3ChromaTex, u_xlat1.xy);
					    u_xlat1 = texture(_History4ChromaTex, u_xlat1.xy);
					    u_xlat15 = u_xlat1.x + -0.5;
					    u_xlat1.x = u_xlat4.x + -0.5;
					    u_xlat2.z = u_xlat1.x * -0.344139993 + (-u_xlat2.y);
					    u_xlat2.w = u_xlat1.x * 1.77199996;
					    u_xlat1 = texture(_History3LumaTex, vs_TEXCOORD1.xy);
					    u_xlat1.xyz = u_xlat2.xzw + u_xlat1.xxx;
					    u_xlat0.xyz = u_xlat1.xyz * vec3(vec3(_History3Weight, _History3Weight, _History3Weight)) + u_xlat0.xyz;
					    u_xlat3.z = u_xlat15 * -0.344139993 + (-u_xlat3.y);
					    u_xlat3.w = u_xlat15 * 1.77199996;
					    u_xlat1 = texture(_History4LumaTex, vs_TEXCOORD1.xy);
					    u_xlat1.xyz = u_xlat3.xzw + u_xlat1.xxx;
					    u_xlat0.xyz = u_xlat1.xyz * vec3(vec3(_History4Weight, _History4Weight, _History4Weight)) + u_xlat0.xyz;
					    u_xlat15 = _History1Weight + _History2Weight;
					    u_xlat15 = u_xlat15 + _History3Weight;
					    u_xlat15 = u_xlat15 + _History4Weight;
					    u_xlat15 = u_xlat15 + 1.0;
					    SV_Target0.xyz = u_xlat0.xyz / vec3(u_xlat15);
					    return;
					}"
				}
				SubProgram "d3d11 " {
					Keywords { "UNITY_COLORSPACE_GAMMA" }
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
						float _History1Weight;
						float _History2Weight;
						float _History3Weight;
						float _History4Weight;
					};
					uniform  sampler2D _MainTex;
					uniform  sampler2D _History1LumaTex;
					uniform  sampler2D _History1ChromaTex;
					uniform  sampler2D _History2LumaTex;
					uniform  sampler2D _History2ChromaTex;
					uniform  sampler2D _History3LumaTex;
					uniform  sampler2D _History3ChromaTex;
					uniform  sampler2D _History4LumaTex;
					uniform  sampler2D _History4ChromaTex;
					in  vec2 vs_TEXCOORD0;
					in  vec2 vs_TEXCOORD1;
					layout(location = 0) out vec4 SV_Target0;
					vec4 u_xlat0;
					vec4 u_xlat1;
					vec4 u_xlat2;
					vec4 u_xlat3;
					vec4 u_xlat4;
					float u_xlat5;
					float u_xlat15;
					void main()
					{
					    u_xlat0 = texture(_History1LumaTex, vs_TEXCOORD1.xy);
					    u_xlat5 = vs_TEXCOORD1.x * _MainTex_TexelSize.z;
					    u_xlat5 = u_xlat5 * 0.5;
					    u_xlat5 = floor(u_xlat5);
					    u_xlat5 = u_xlat5 * 2.0 + 0.5;
					    u_xlat1.z = u_xlat5 * _MainTex_TexelSize.x + _MainTex_TexelSize.x;
					    u_xlat1.x = u_xlat5 * _MainTex_TexelSize.x;
					    u_xlat1.yw = vs_TEXCOORD1.yy;
					    u_xlat2 = texture(_History1ChromaTex, u_xlat1.zw);
					    u_xlat5 = u_xlat2.x + -0.5;
					    u_xlat2.xy = vec2(u_xlat5) * vec2(1.40199995, 0.714139998);
					    u_xlat3 = texture(_History1ChromaTex, u_xlat1.xy);
					    u_xlat5 = u_xlat3.x + -0.5;
					    u_xlat2.z = u_xlat5 * -0.344139993 + (-u_xlat2.y);
					    u_xlat2.w = u_xlat5 * 1.77199996;
					    u_xlat0.xyz = u_xlat0.xxx + u_xlat2.xzw;
					    u_xlat2 = texture(_MainTex, vs_TEXCOORD0.xy);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(vec3(_History1Weight, _History1Weight, _History1Weight)) + u_xlat2.xyz;
					    SV_Target0.w = u_xlat2.w;
					    u_xlat2 = texture(_History2LumaTex, vs_TEXCOORD1.xy);
					    u_xlat3 = texture(_History2ChromaTex, u_xlat1.zw);
					    u_xlat15 = u_xlat3.x + -0.5;
					    u_xlat3.xy = vec2(u_xlat15) * vec2(1.40199995, 0.714139998);
					    u_xlat4 = texture(_History2ChromaTex, u_xlat1.xy);
					    u_xlat15 = u_xlat4.x + -0.5;
					    u_xlat3.z = u_xlat15 * -0.344139993 + (-u_xlat3.y);
					    u_xlat3.w = u_xlat15 * 1.77199996;
					    u_xlat2.xyz = u_xlat2.xxx + u_xlat3.xzw;
					    u_xlat0.xyz = u_xlat2.xyz * vec3(_History2Weight) + u_xlat0.xyz;
					    u_xlat2 = texture(_History3ChromaTex, u_xlat1.zw);
					    u_xlat3 = texture(_History4ChromaTex, u_xlat1.zw);
					    u_xlat15 = u_xlat3.x + -0.5;
					    u_xlat3.xy = vec2(u_xlat15) * vec2(1.40199995, 0.714139998);
					    u_xlat15 = u_xlat2.x + -0.5;
					    u_xlat2.xy = vec2(u_xlat15) * vec2(1.40199995, 0.714139998);
					    u_xlat4 = texture(_History3ChromaTex, u_xlat1.xy);
					    u_xlat1 = texture(_History4ChromaTex, u_xlat1.xy);
					    u_xlat15 = u_xlat1.x + -0.5;
					    u_xlat1.x = u_xlat4.x + -0.5;
					    u_xlat2.z = u_xlat1.x * -0.344139993 + (-u_xlat2.y);
					    u_xlat2.w = u_xlat1.x * 1.77199996;
					    u_xlat1 = texture(_History3LumaTex, vs_TEXCOORD1.xy);
					    u_xlat1.xyz = u_xlat2.xzw + u_xlat1.xxx;
					    u_xlat0.xyz = u_xlat1.xyz * vec3(vec3(_History3Weight, _History3Weight, _History3Weight)) + u_xlat0.xyz;
					    u_xlat3.z = u_xlat15 * -0.344139993 + (-u_xlat3.y);
					    u_xlat3.w = u_xlat15 * 1.77199996;
					    u_xlat1 = texture(_History4LumaTex, vs_TEXCOORD1.xy);
					    u_xlat1.xyz = u_xlat3.xzw + u_xlat1.xxx;
					    u_xlat0.xyz = u_xlat1.xyz * vec3(vec3(_History4Weight, _History4Weight, _History4Weight)) + u_xlat0.xyz;
					    u_xlat15 = _History1Weight + _History2Weight;
					    u_xlat15 = u_xlat15 + _History3Weight;
					    u_xlat15 = u_xlat15 + _History4Weight;
					    u_xlat15 = u_xlat15 + 1.0;
					    SV_Target0.xyz = u_xlat0.xyz / vec3(u_xlat15);
					    return;
					}"
				}
			}
		}
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 549493
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
					    phase0_Output0_1.w = (u_xlatb0) ? u_xlat2 : in_TEXCOORD0.y;
					    phase0_Output0_1.xyz = in_TEXCOORD0.xyx;
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
						float _History1Weight;
						float _History2Weight;
						float _History3Weight;
						float _History4Weight;
					};
					uniform  sampler2D _MainTex;
					uniform  sampler2D _History1LumaTex;
					uniform  sampler2D _History2LumaTex;
					uniform  sampler2D _History3LumaTex;
					uniform  sampler2D _History4LumaTex;
					in  vec2 vs_TEXCOORD0;
					layout(location = 0) out vec4 SV_Target0;
					vec4 u_xlat0;
					vec4 u_xlat1;
					float u_xlat6;
					void main()
					{
					    u_xlat0 = texture(_History1LumaTex, vs_TEXCOORD0.xy);
					    u_xlat1 = texture(_MainTex, vs_TEXCOORD0.xy);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(vec3(_History1Weight, _History1Weight, _History1Weight)) + u_xlat1.xyz;
					    SV_Target0.w = u_xlat1.w;
					    u_xlat1 = texture(_History2LumaTex, vs_TEXCOORD0.xy);
					    u_xlat0.xyz = u_xlat1.xyz * vec3(_History2Weight) + u_xlat0.xyz;
					    u_xlat1 = texture(_History3LumaTex, vs_TEXCOORD0.xy);
					    u_xlat0.xyz = u_xlat1.xyz * vec3(vec3(_History3Weight, _History3Weight, _History3Weight)) + u_xlat0.xyz;
					    u_xlat1 = texture(_History4LumaTex, vs_TEXCOORD0.xy);
					    u_xlat0.xyz = u_xlat1.xyz * vec3(vec3(_History4Weight, _History4Weight, _History4Weight)) + u_xlat0.xyz;
					    u_xlat6 = _History1Weight + _History2Weight;
					    u_xlat6 = u_xlat6 + _History3Weight;
					    u_xlat6 = u_xlat6 + _History4Weight;
					    u_xlat6 = u_xlat6 + 1.0;
					    SV_Target0.xyz = u_xlat0.xyz / vec3(u_xlat6);
					    return;
					}"
				}
			}
		}
	}
}